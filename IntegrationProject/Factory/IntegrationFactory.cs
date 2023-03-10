using IntegrationProject.Data;
using IntegrationProject.Interfaces;

namespace IntegrationProject.Factory
{
    internal class IntegrationFactory
    {
        KDBcontext _context;
        public IntegrationFactory(KDBcontext context)
        {
            _context = context;
        }
        public IEntity_Actions CreateAccountingProvider(IGateway gateway)
        {
            Console.WriteLine("Checking if the user has a selected a provider");

            string provider = gateway.RetrieveSelectedProvider(_context);

            if (provider == null) throw new Exception("Provider is null");

            Console.WriteLine("Creating Entity Handler class\n");

            return new EntityHandler(gateway, _context, provider);
        }

        public void CreateConnection(string provider, IGateway gateway)
        {
            switch(provider)
            {
                case "Sage":
                    Console.WriteLine("Creating Initial connection with Sage");
                    break;
                case "Xero":
                    Console.WriteLine("Creating Initial connection with Xero");
                    break;
                case "QuickBooks":
                    Console.WriteLine("Creating Initial connection with QuickBooks");
                    break;
                default:
                    throw new ArgumentException("Invalid Provider");
            }

            gateway.TokenSave(_context, Guid.NewGuid().ToString());
            gateway.SaveSelectedProvider(_context, provider);
        }

        public void Disconnect(IGateway gateway)
        {
            Console.WriteLine("\nDisconencting Accounting Provider and setting values to null...");
            gateway.SaveSelectedProvider(_context, "");
            gateway.TokenSave(_context, "");
        }
    }
}
