using IntegrationProject.Interfaces;
using IntegrationProject.Responses;

namespace IntegrationProject.API
{
    internal class SageClientAPI : IAPI_Actions
    {
        public IResponse Post(IEntity entity)
        {
            IClient client = (IClient)entity;
            Console.WriteLine("Posting Client to Sage");

            return new SageClientResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
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

        public void Accept(IAPI_Visitor visitor)
        {
            visitor.Visit(this);
        }

        public bool IsMatch(IEntity entity, string provider)
        {
            return entity is IClient && provider == "Sage";
        }
    }
}
