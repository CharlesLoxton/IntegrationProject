using IntegrationProject.Interfaces;
using IntegrationProject.Models;

namespace IntegrationProject.Data
{
    internal class Gateway : IGateway
    {
        public int UserId { get; set; }

        public Gateway(int userId)
        {
            UserId = userId;
        }

        public string RetrieveSelectedProvider(KDBcontext context)
        {
            Console.WriteLine("Retieving provider: Sage\n");
            return context.Provider; ;
        }

        public void SaveSelectedProvider(KDBcontext context, string provider)
        {
            context.Provider = provider;
            Console.WriteLine("Saving provider with name: " + provider);
        }

        public string TokenRetrieval(KDBcontext context)
        {
            Console.WriteLine("Retrieving token");
            return context.Token;
        }

        public void TokenSave(KDBcontext context, string token)
        {
            Console.WriteLine("Saving token in KOST");
            context.Token = token;
        }

        public IEnumerable<IEntity> RetrieveAllEntities(KDBcontext context, IEntity entity)
        {
            if(entity is IClient)
            {
                foreach (var item in context.Clients)
                {
                    yield return item;
                }
            }
            //Add the rest here
        }

        public void SaveGUID(KDBcontext context, IEntity entity, int entityID, string guid)
        {
            Console.WriteLine("Saving guid in KOST for " + entity.GetType().Name);
        }

        public void AddClient(KDBcontext context, IClient client)
        {
            Console.WriteLine("Saving Client in KOST");
        }

        public void SaveProviderInstance(KDBcontext context, string id)
        {
            Console.WriteLine("Saving Provider Instance in KOST");
            context.providerInstance = id;
        }

        public string RetrieveProviderInstance(KDBcontext context)
        {
            Console.WriteLine("Retrieving Provider Instance in KOST");
            return context.providerInstance;
        }
    }
}
