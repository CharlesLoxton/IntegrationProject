using IntegrationProject.Data;
using IntegrationProject.Models;

namespace IntegrationProject.Interfaces
{
    internal interface IGateway
    {
        public int UserId { get; set; }

        public string TokenRetrieval(KDBcontext context); //Retrieve the API Token where Kost.UserID = this.UserID

        public void TokenSave(KDBcontext context, string token); //Save the API token where Kost.UserID = this.UserID

        public void SaveSelectedProvider(KDBcontext context, string provider); //Save the Provider Name where Kost.UserID = this.UserID

        public string RetrieveSelectedProvider(KDBcontext context); //Retrieve the provider Name where Kost.UserID = this.UserID

        public void SaveGUID(KDBcontext context, IEntity entity, int entityID, string guid); //Save the GUID for the corresponding entity object

        public IEnumerable<Client> RetrieveAllClients(KDBcontext context); //Yield return a list of clients where Kost.UserID = this.UserID

        public void AddClient(KDBcontext context, IClient client); //Add a client for a user where Kost.UserID = this.UserID
    }
}
