using IntegrationProject.Interfaces;

namespace IntegrationProject.Models
{
    internal class Client : IClient
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public bool isCompany { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string CCEmails { get; set; }
        public string VATNumber { get; set; }

        public DateTime CreationDate { get; set; }

        public int UserId { get; set; }

        public string? Guid { get; set; }
    }
}
