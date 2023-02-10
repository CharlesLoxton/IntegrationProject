using IntegrationProject.Interfaces;
using IntegrationProject.Responses;

namespace IntegrationProject.API
{
    internal class SageInvoiceAPI : IAPI_Actions
    {
        public IResponse Post(IEntity entity)
        {
            Console.WriteLine("Posting Invoice to Sage");

            IInvoice invoice = (IInvoice)entity;

            return new SageInvoiceResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                InvoiceName = invoice.InvoiceName,
                Reference = invoice.Guid
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
            return entity is IInvoice && provider == "Sage";
        }
    }
}
