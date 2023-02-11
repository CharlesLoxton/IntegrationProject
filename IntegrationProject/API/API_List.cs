using IntegrationProject.Interfaces;

namespace IntegrationProject.API
{
    internal class API_List
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
            foreach (IAPI_Actions api in _apis)
            {
                if (api.IsMatch(entity, provider))
                {
                    return api;
                }
            }

            throw new ArgumentNullException("API is null");
        }
    }
}
