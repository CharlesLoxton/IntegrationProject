using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Models
{
    internal class APLink
    {
        public int UserID { get; set; }

        public string? GUID { get; set; }

        public ProviderInfo? provider { get; set; }

        public CompanyInfo? company { get; set; }

        public DateInfo? date { get; set; }
    }
}
