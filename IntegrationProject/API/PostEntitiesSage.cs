using IntegrationProject.Interfaces;
using IntegrationProject.Responses;

namespace IntegrationProject.API
{
    internal class PostEntitiesSage
    {
        public IResponse PostClient(IClient entity)
        {
            Console.WriteLine("Posting Client to Sage");

            return new SageClientResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                Name = entity.Name,
                Reference = entity.Guid
            };
        }

        public IResponse PostInvoice(IInvoice entity)
        {
            Console.WriteLine("Posting Invoice to Sage");

            return new SageInvoiceResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                InvoiceName = entity.InvoiceName,
                Reference = entity.Guid
            };
        }

        public IResponse PostQuote(IQuote entity)
        {
            return new SageQuoteResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                QuotationName = entity.QuotationName,
                Reference = entity.Guid
            };
        }

        public IResponse PostPurchaseOrder(IPurchaseOrder entity)
        {
            return new SagePurchaseOrderResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                PONumber = entity.PONumber,
                Reference = entity.Guid
            };
        }
    }
}
