using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Interfaces
{
    internal interface IPurchaseOrder : IEntity
    {
        public string PONumber { get; set; }
    }
}
