using IntegrationProject.Interfaces;
using IntegrationProject.Items;

namespace IntegrationProject.Models
{
    internal class Quote : IQuote
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ClientId { get; set; }

        public string QuotationAddress { get; set; }

        public string QuotationName { get; set; }

        public string Note { get; set; }
        //--------------------------

        public string Number { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime? ArchivedDate { get; set; }//null if not archived

        public DateTime SentDate { get; set; }

        public DateTime? AcceptedDate { get; set; }

        public DateTime CreationDate { get; set; }

        public string AcceptedBy { get; set; }

        public decimal VAT { get; set; }

        public bool MaterialVAT { get; set; }

        public decimal DiscountAmount { get; set; }

        public bool IsArchived { get; set; }

        public int Deposit { get; set; }
        public string HiddenItemDescription { get; set; }

        public IEnumerable<QuickQuotationItem> Items { get; set; }

        public string? Guid { get; set; }
    }
}
