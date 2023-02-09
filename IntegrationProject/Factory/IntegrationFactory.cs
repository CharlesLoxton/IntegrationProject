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
        public AccountingProvider CreateAccountingProvider(IGateway gateway)
        {
            Console.WriteLine("Checking if the user has a selected a provider");

            string provider = gateway.RetrieveSelectedProvider(_context);

            if (provider == null) throw new Exception("Provider is null");

            Console.WriteLine("Creating Accounting provider class");

            return new AccountingProvider(gateway, provider, _context);
        }

        public void CreateConnection(string provider, IGateway gateway)
        {
            if (provider == "Sage")
            {
                Console.WriteLine("Creating Initial connection with Sage");
                gateway.TokenSave(_context, Guid.NewGuid().ToString());
                gateway.SaveSelectedProvider(_context, provider);
            }
        }

        public void Disconnect(IGateway gateway)
        {
            Console.WriteLine("\nDisconencting Accounting Provider and setting values to null...");
            gateway.SaveSelectedProvider(_context, "");
            gateway.TokenSave(_context, "");
        }
    }
}
