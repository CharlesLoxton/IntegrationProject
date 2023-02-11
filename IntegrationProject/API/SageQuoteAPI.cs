using IntegrationProject.Interfaces;
using IntegrationProject.Responses;

namespace IntegrationProject.API
{
    internal class SageQuoteAPI : IAPI_Actions
    {
        public IResponse Post(IEntity entity)
        {
            IQuote quote = (IQuote)entity;
            return new QuoteResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                QuotationName = quote.QuotationName,
                Reference = quote.Guid
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
            return entity is IQuote && provider == "Sage";
        }
    }
}
