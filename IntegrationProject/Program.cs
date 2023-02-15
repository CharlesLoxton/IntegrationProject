using IntegrationProject.Data;
using IntegrationProject.Interfaces;
using IntegrationProject.Models;
using IntegrationProject.Factory;

//This is just an example object of the DBcontext object that we will use in EF core
KDBcontext context = new KDBcontext();

int userID = 1;

IClient client = new Client()
{
    Id = 1,
    Name = "Sage Client",
    Guid = null,
    UserId = userID
};

IInvoice invoice = new Invoice()
{
    Id = 1,
    InvoiceName = "Sage Invoice",
    Guid = null,
    UserId  = userID
};

//This is what Neil will have to add to his Startup.cs class
//services.AddDbContext<KDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//services.AddSingleton<IntegrationFactory>(provider => new IntegrationFactory(provider.GetService<KDbContext>()));


var factory = new IntegrationFactory(context);

//Instantiate a gateway with the userID in every route of your controllers
IGateway gateway = new Gateway(userID);

//This is how you connect a user with an Accounting Provider
factory.CreateConnection("Sage", gateway);

//Create our EntityHandler that will handle calls to the api
IEntity_Actions provider = factory.CreateAccountingProvider(gateway);

//Call Upsert on the EntityHandler object
provider.Upsert(client);
provider.Upsert(invoice);

//Disconnect the current accounting provider
factory.Disconnect(gateway);
