using IntegrationProject.API;

namespace IntegrationProject.Interfaces
{
    internal interface IAPI_Visitor
    {
        void Visit(SageClientAPI api);
        void Visit(SageInvoiceAPI api);
        void Visit(SageQuoteAPI api);
        void Visit(SagePurchaseOrderAPI api);
        //void Visit(XeroClientAPI api);
        //void Visit(XeroInvoiceAPI api);
        //void Visit(XeroQuoteAPI api);
        //void Visit(XeroPurchaseOrderAPI api);
    }
}
