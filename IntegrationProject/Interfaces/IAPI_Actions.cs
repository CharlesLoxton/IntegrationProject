namespace IntegrationProject.Interfaces
{
    internal interface IAPI_Actions
    {
        IResponse Post(IEntity entity);
        IEntity Read(int accountingProviderId);
        void Delete(int accountingProviderId);
        void Accept(IAPI_Visitor visitor);
        bool IsMatch(IEntity entity, string provider);
    }
}
