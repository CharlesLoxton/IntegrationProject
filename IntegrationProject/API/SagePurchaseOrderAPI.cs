using IntegrationProject.Interfaces;
using IntegrationProject.Responses;

namespace IntegrationProject.API
{
    internal class SagePurchaseOrderAPI : IAPI_Actions
    {
        public IResponse Post(IEntity entity)
        {
            IPurchaseOrder PO = (IPurchaseOrder)entity;

            return new PurchaseOrderResponse()
            {
                response_Id = Guid.NewGuid().ToString(),
                companyId = 34235,
                CompanyName = "BoBTheBuilder",
                PONumber = PO.PONumber,
                Reference = PO.Guid
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
            return entity is IPurchaseOrder && provider == "Sage";
        }
    }
}
