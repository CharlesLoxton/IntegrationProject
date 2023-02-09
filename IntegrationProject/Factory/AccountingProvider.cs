using IntegrationProject.Data;
using IntegrationProject.Interfaces;

namespace IntegrationProject.Factory
{
    internal class AccountingProvider
    {
        IGateway _gateway;
        public string _provider;
        KDBcontext _context;

        public AccountingProvider(IGateway gateway, string provider, KDBcontext context)
        {
            _gateway = gateway;
            _provider = provider;
            _context = context;
        }

        public IEntity_Actions<IClient> Client()
        {
            return new EntityHandler<IClient>(_gateway, _context, _provider, "Client");
        }

        public IEntity_Actions<IInvoice> Invoice()
        {
            return new EntityHandler<IInvoice>(_gateway, _context, _provider, "Invoice");
        }

        public IEntity_Actions<IQuote> Quote()
        {
            return new EntityHandler<IQuote>(_gateway, _context, _provider, "Quote");
        }
        public IEntity_Actions<IPurchaseOrder> PurchaseOrder()
        {
            return new EntityHandler<IPurchaseOrder>(_gateway, _context, _provider, "PurchaseOrder");
        }
    }
}
