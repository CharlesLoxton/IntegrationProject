using IntegrationProject.Interfaces;
using IntegrationProject.Items;

namespace IntegrationProject.Models
{
    internal class PurchaseOrder : IPurchaseOrder
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string PONumber { get; set; }

        public DateTime? Sent { get; set; }

        public List<POItem> Items { get; set; }

        public int SupplierId { get; set; }

        public int ContactSupplierId { get; set; }

        public DateTime CreationDate { get; set; }

        public int? projectId { get; set; }

        public string? Guid { get; set; }
    }
}
