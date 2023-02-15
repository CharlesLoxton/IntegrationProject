
namespace IntegrationProject.Models
{
    internal class APLink
    {
        public string GUID { get; set; } = string.Empty;

        public ProviderInfo? provider { get; set; }

        public CompanyInfo? company { get; set; }

        public DateInfo? date { get; set; }
    }
}
