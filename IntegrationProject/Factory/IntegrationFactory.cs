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
            Console.WriteLine("Check if the user has a selected a provider");

            if (gateway.RetrieveSelectedProvider(_context) == null) throw new Exception("Provider is null");

            Console.WriteLine("Creating Accounting provider class");

            return new AccountingProvider(gateway, gateway.RetrieveSelectedProvider(_context), _context);
        }

        public void CreateConnection(string provider, IGateway gateway)
        {
            if (provider == "Sage")
            {
                Console.WriteLine("Creating Initial connection with Sage");
                gateway.TokenSave(_context, "123");
                gateway.SaveSelectedProvider(_context, provider);
            }
        }

        public void Disconnect(IGateway gateway)
        {
            Console.WriteLine("Disconencting Accounting Provider and setting values to null...");
            gateway.SaveSelectedProvider(_context, "");
            gateway.TokenSave(_context, "");
        }

        public async void Callback(string callbackUrl)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(callbackUrl);
                var responseString = await response.Content.ReadAsStringAsync();

                // Process the response and return the appropriate result
            }
        }
    }
}
