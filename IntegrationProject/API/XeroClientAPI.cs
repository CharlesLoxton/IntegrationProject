using IntegrationProject.Interfaces;
using IntegrationProject.Responses;

namespace IntegrationProject.API
{
    internal class XeroClientAPI : IAPI_Actions
    {
        public IResponse Post(IEntity entity)
        {
            IClient client = (IClient)entity;
            Console.WriteLine("Posting Client to Xero");

            return new ClientResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 7658,
                CompanyName = "BoBTheBuilder",
                Name = client.Name,
                Reference = client.Guid
            };
        }

        public void Delete(int accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public IEntity Read(int accountingProviderId)
        {
            throw new NotImplementedException();
        }

        public bool IsMatch(IEntity entity, string provider)
        {
            return entity is IClient && provider == "Xero";
        }
    }
}
