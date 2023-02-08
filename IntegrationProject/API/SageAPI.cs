using IntegrationProject.Interfaces;

namespace IntegrationProject.API
{
    internal class SageAPI
    {
        public IResponse PostSage(IEntity entity, string entityName)
        {
            PostEntitiesSage sage = new PostEntitiesSage();

            switch (entityName)
            {
                case "Client":
                    return sage.PostClient((IClient)entity);
                case "Invoice":
                    return sage.PostInvoice((IInvoice)entity);
                case "Quote":
                    return sage.PostQuote((IQuote)entity);
                case "PurchaseOrder":
                    return sage.PostPurchaseOrder((IPurchaseOrder)entity);
                default:
                    throw new ArgumentException("Invalid entity name");
            }
        }
    }

    //Add Read and Delete here as well
}
