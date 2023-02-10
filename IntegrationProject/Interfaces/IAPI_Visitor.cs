using IntegrationProject.API;

namespace IntegrationProject.Interfaces
{
    internal interface IAPI_Visitor
    {
        void Visit(IAPI_Actions api);
    }
}
