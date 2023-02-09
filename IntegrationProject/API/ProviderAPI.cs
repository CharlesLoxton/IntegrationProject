using IntegrationProject.Data;
using IntegrationProject.Factory;
using IntegrationProject.Interfaces;
using IntegrationProject.Models;

namespace IntegrationProject.API
{
    internal class ProviderAPI
    {
        KDBcontext _context;
        IGateway _gateway;
        IAPI_Actions? API;
        string provider;
        string type;

        public ProviderAPI(KDBcontext context, IGateway gateway, string _provider, string _type)
        {
            _context = context;
            _gateway = gateway;
            provider = _provider;
            type = _type;

            API = new EntityProviderFactory().SetProviderEntityAPI(provider, type);

            if(API == null) throw new ArgumentException("API is null");
        }

        //This is a universal way of Posting for all entities
        public void Post(IEntity entity)
        {
            try
            {
                IResponse? response = null;

                string Token = _gateway.TokenRetrieval(_context);

                //Check if client.GUID exists in our APLink table
                if (entity.Guid != null)
                {
                    APLink link = _gateway.FindAPLinkByGUID(_context, entity.Guid, provider);
                    //If it returns an APLink object we know it exists in Sage, but we should do a GET check to make sure

                    //Updating the Entity in AP happens here
                }

                //This would be a first time Create
                else
                {
                    string guid = Guid.NewGuid().ToString();

                    entity.Guid = guid;

                    //Make the Post to the corresponding API and entity type
                    response = API?.Post(entity);

                    if (response == null) return;
                    
                    APLink link = new APLink()
                    {
                        UserID = entity.UserId,
                        GUID = response.Reference,
                        provider = new ProviderInfo()
                        {
                            AccountingProviderID = response.response_Id,
                            AccountingProviderName = provider,
                        },
                        company = new CompanyInfo()
                        {
                            ComapnyID = response.companyId,
                            ComapnyName = response.CompanyName,
                        },
                        date = new DateInfo()
                        {
                            ConnectedDate = DateTime.Now,
                            DisconnectedDate = null
                        }
                    };

                    _gateway.SaveGUID(_context, type, entity.Id, response.Reference);
                    _gateway.SaveAPLink(_context, link);
                    _gateway.TokenSave(_context, Guid.NewGuid().ToString());
                }

                Console.WriteLine("Creating Entity Completed");
                Console.WriteLine("\n");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Posting to Provider API " + ex.Message);
            }
        }
    }
}
