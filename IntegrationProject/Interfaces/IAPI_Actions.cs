namespace IntegrationProject.Interfaces
{
    internal interface IAPI_Actions
    {
        IResponse Post(IEntity entity);
        IEntity Read(int accountingProviderId);
        void Delete(int accountingProviderId);
        bool IsMatch(IEntity entity, string provider);
    }
}
