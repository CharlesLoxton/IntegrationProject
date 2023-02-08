using IntegrationProject.Interfaces;

namespace IntegrationProject.Responses
{
    internal class SageInvoiceResponse : IResponse
    {
        //We have to add all the fields from the response object here
        public string? response_Id { get; set; }
        public int companyId { get; set; }
        public string? CompanyName { get; set; }
        public string? InvoiceName { get; set; }
        public string? Reference { get; set; }
    }
}
