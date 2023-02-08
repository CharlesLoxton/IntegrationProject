using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Interfaces
{
    internal interface IQuote : IEntity
    {
        public string QuotationName { get; set; }
    }
}
