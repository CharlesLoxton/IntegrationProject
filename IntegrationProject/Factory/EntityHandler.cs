using IntegrationProject.Data;
using IntegrationProject.Interfaces;
using IntegrationProject.API;

namespace IntegrationProject.Factory
{
    class EntityHandler : IEntity_Actions
    {
        IGateway _gateway;
        KDBcontext _context;
        string _provider;

        public EntityHandler(IGateway gateway, KDBcontext context, string provider)
        {
            _gateway = gateway;
            _context = context;
            _provider = provider;
        }

        public void Upsert(IEntity entity)
        {
            try
            {
                ProviderAPI api = new ProviderAPI(_context, _gateway, _provider);

                //We need to check if Neil is using transactions, if he isn't then we have to manually create a transaction in EF core
                if (_context.Database.CurrentTransaction != null)
                {
                    api.Post(entity);
                }
                else
                {
                    using (var transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            api.Post(entity);
                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw new Exception("Error with transaction");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int accountingProviderId)
        {
            throw new NotImplementedException();
        }
        public void Sync()
        {
            throw new NotImplementedException();
        }
    }
}
