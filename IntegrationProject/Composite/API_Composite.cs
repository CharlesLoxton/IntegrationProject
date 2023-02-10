using IntegrationProject.API;
using IntegrationProject.Interfaces;
using IntegrationProject.Visitors;

namespace IntegrationProject.Composite
{
    internal class API_Composite
    {
        private readonly List<IAPI_Actions> _apis = new List<IAPI_Actions>
        {
            new SageClientAPI(),
            new SageInvoiceAPI(),
            new SageQuoteAPI(),
            new SagePurchaseOrderAPI(),
            new XeroClientAPI(),
            new XeroInvoiceAPI()
            //Add the rest here
        };

        public IAPI_Actions GetAPI(IEntity entity, string provider)
        {
            API_Visitor visitor = new API_Visitor(entity, provider);

            foreach (IAPI_Actions api in _apis)
            {
                api.Accept(visitor);
            }

            return visitor.Result ?? throw new ArgumentNullException("Result is null");
        }
    }
}
