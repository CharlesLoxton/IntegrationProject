using IntegrationProject.Data;
using IntegrationProject.Interfaces;
using IntegrationProject.API;

namespace IntegrationProject.Factory
{
    internal class EntityHandler : IEntity_Actions
    {
        IGateway _gateway;
        KDBcontext _context;
        string _provider;
        string _type;

        public EntityHandler(IGateway gateway, KDBcontext context, string provider, string type)
        {
            _gateway = gateway;
            _context = context;
            _provider = provider;
            _type = type;
        }

        public void Upsert(IEntity entity)
        {
            try
            {
                AccountingProviderAPI api = new AccountingProviderAPI(_context, _gateway);

                //We need to check if Neil is using transactions, if he isn't then we have to manually create a transaction in EF core
                if (_context.Database.CurrentTransaction != null)
                {
                    api.Post(entity, _provider, _type);
                }
                else
                {
                    using (var transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            api.Post(entity, _provider, _type);
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
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void Delete(int accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public IEntity Read(int? accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public void Sync()
        {
            throw new NotImplementedException();
        }
    }
}
