using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Interfaces
{
    internal interface IInvoice : IEntity
    {
        //We will add all the Invoice specific properties here
        public string InvoiceName { get; set; }
    }
}
