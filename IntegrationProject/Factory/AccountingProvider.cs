using IntegrationProject.Data;
using IntegrationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IEntity_Actions Client()
        {
            return new EntityHandler(_gateway, _context, _provider, "Client");
        }

        public IEntity_Actions Invoice()
        {
            return new EntityHandler(_gateway, _context, _provider, "Invoice");
        }

        public IEntity_Actions Quote()
        {
            return new EntityHandler(_gateway, _context, _provider, "Quote");
        }
        public IEntity_Actions PurchaseOrder()
        {
            return new EntityHandler(_gateway, _context, _provider, "PurchaseOrder");
        }

    }
}
