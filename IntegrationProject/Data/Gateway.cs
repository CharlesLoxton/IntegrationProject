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
            return "Sage";
        }

        public void SaveSelectedProvider(KDBcontext context, string provider)
        {
            Console.WriteLine("Saving provider with name: " + provider);
        }

        public string TokenRetrieval(KDBcontext context)
        {
            Console.WriteLine("Retrieving token");
            return "123";
        }

        public void TokenSave(KDBcontext context, string token)
        {
            Console.WriteLine("Saving token in KOST");
        }

        public IEnumerable<Client> RetrieveAllClients(KDBcontext context)
        {
            List<Client> clients = new List<Client>();

            foreach (var item in clients)
            {
                yield return item;
            }
        }

        public void SaveAPLink(KDBcontext context, APLink link)
        {
            Console.WriteLine("Saving APLink in KOST");
        }

        public void SaveGUID(KDBcontext context, IEntity entity, int entityID, string guid)
        {
            Console.WriteLine("Saving guid in KOST for " + entity.GetType().Name);
        }

        public void AddClient(KDBcontext context, IClient client)
        {
            Console.WriteLine("Saving Client in KOST");
        }
    }
}
