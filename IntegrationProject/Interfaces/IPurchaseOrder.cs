using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Interfaces
{
    internal interface IPurchaseOrder : IEntity
    {
        //We will add all the PO specific properties here
        public string PONumber { get; set; }
    }
}
