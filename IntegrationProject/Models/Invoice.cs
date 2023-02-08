using IntegrationProject.Interfaces;
using IntegrationProject.Items;

namespace IntegrationProject.Models
{
    internal class Invoice : IInvoice
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ClientId { get; set; }

        public string InvoiceAddress { get; set; }
        public string InvoiceName { get; set; }

        public string Note { get; set; }
        //--------------------------
        public string Number { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime? Paid { get; set; }//null if not paid
        public DateTime? ArchivedDate { get; set; }//null if not archived

        public DateTime SentDate { get; set; }
        public DateTime CreationDate { get; set; }

        public decimal VAT { get; set; }

        public bool MaterialVAT { get; set; }

        public bool IsArchived { get; set; }

        public decimal Discount { get; set; }
        public string HiddenItemDescription { get; set; }
        public IEnumerable<QuickInvoiceItem> Items { get; set; }

        public string? Guid { get; set; }
    }
}
