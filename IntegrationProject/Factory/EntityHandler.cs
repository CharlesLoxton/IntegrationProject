using IntegrationProject.Data;
using IntegrationProject.Interfaces;
using IntegrationProject.API;

namespace IntegrationProject.Factory
{
    class EntityHandler<TEntity> : IEntity_Actions<TEntity> where TEntity : IEntity
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

        public void Upsert(TEntity entity)
        {
            try
            {
                ProviderAPI api = new ProviderAPI(_context, _gateway, _provider, _type);

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

        public TEntity Read(int? accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public void Sync()
        {
            throw new NotImplementedException();
        }
    }
}
