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
        string provider;

        public ProviderAPI(KDBcontext context, IGateway gateway, string _provider)
        {
            _context = context;
            _gateway = gateway;
            provider = _provider;
        }

        //This is a universal way of Posting for all entities
        public void Post(IEntity entity)
        {
            try
            {
                string Token = _gateway.TokenRetrieval(_context);

                //Check if client.GUID exists in our APLink table
                if (entity.Guid != null)
                {
                    //APLink? link = _context.APLink.FirstOrDefault(x => x.GUID == entity.Guid && x.provider.AccountingProviderName == provider);
                    //If it returns an APLink object we know it exists in Sage, but we should do a GET check to make sure

                    //Updating the Entity in AP happens here
                }

                //This would be a first time Create
                else
                {
                    string guid = Guid.NewGuid().ToString();

                    entity.Guid = guid;

                    //Make the Post to the corresponding API and entity type
                    IAPI_Actions api = new API_List().GetAPI(entity, provider);

                    IResponse response = api.Post(entity);
                    
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

                    _gateway.SaveGUID(_context, entity, entity.Id, guid);
                    _context.APLink.Add(link);
                    _gateway.TokenSave(_context, Guid.NewGuid().ToString());
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Posting to Provider API " + ex.Message);
            }
        }
    }
}
