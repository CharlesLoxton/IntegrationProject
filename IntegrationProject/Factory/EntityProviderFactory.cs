using IntegrationProject.API;
using IntegrationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Factory
{
    internal class EntityProviderFactory
    {
        public IAPI_Actions SetProviderEntityAPI(string provider, string type)
        {
            switch (provider)
            {
                case "Sage":
                    switch (type)
                    {
                        case "Client":
                            return new SageClientAPI();
                        case "Quote":
                            return new SageQuoteAPI();
                        case "Invoice":
                            return new SageInvoiceAPI();
                        case "PurchaseOrder":
                            return new SagePurchaseOrderAPI();
                        default:
                            throw new ArgumentException("Invalid Type");
                    }   
                case "Xero":
                    switch (type)
                    {
                        case "Client":
                            //return new XeroClientAPI();
                        case "Quote":
                            //return new XeroQuoteAPI();
                        case "Invoice":
                            //return new XeroInvoiceAPI();
                        case "PurchaseOrder":
                            //return new XeroPurchaseOrderAPI();
                        default:
                            throw new ArgumentException("Invalid Type");
                    }
                case "QuickBooks":
                    switch (type)
                    {
                        case "Client":
                            //return new QBClientAPI();
                        case "Quote":
                            //return new QBQuoteAPI();
                        case "Invoice":
                            //return new QBInvoiceAPI();
                        case "PurchaseOrder":
                            //return new QBPurchaseOrderAPI();
                        default:
                            throw new ArgumentException("Invalid Type");
                    }
                default:
                    throw new ArgumentException("Invalid Provider Name");
            }
        }
    }
}
