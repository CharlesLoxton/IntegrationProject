
namespace IntegrationProject.Items
{
    internal class POItem
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ItemId { get; set; }

        public int POId { get; set; }

        public int DisciplineId { get; set; }

        public string Description { get; set; }

        public string AddedDescription { get; set; }

        public decimal Qty { get; set; }

        public bool isQuotable { get; set; }
        public bool HasAddedDescription { get; set; }
        public decimal UnitCost { get; set; }
    }
}
