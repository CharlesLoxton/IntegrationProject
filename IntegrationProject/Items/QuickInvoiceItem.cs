using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Items
{
    internal class QuickInvoiceItem
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int QuickInvoiceId { get; set; }

        public int ModuleId { get; set; }

        public string Description { get; set; }

        public decimal Qty { get; set; }

        public string Unit { get; set; }

        public string Type { get; set; }

        public decimal UnitCost { get; set; }

        public decimal TotalCost { get; set; }

        public int? QuickInvoiceItemId { get; set; }

        public IEnumerable<QuickInvoiceItem> Items { get; set; }

        public string AddedDescription { get; set; }

        public bool HasAddedDescription { get; set; }

        public int Markup { get; set; }

        public int UserId { get; set; }

        public bool Hidden { get; set; }

        public int OrderId { get; set; }
    }
}
