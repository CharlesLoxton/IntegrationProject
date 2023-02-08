namespace IntegrationProject.Interfaces
{
    internal interface IResponse
    {
        public string? response_Id { get; set; }
        public int companyId { get; set; }
        public string? CompanyName { get; set; }
        public string? Reference { get; set; }
    }
}
