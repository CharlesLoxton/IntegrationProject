using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Interfaces
{
    internal interface IQuote : IEntity
    {
        //We will add all the Quote specific properties here
        public string QuotationName { get; set; }
    }
}
