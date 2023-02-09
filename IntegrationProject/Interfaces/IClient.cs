using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Interfaces
{
    internal interface IClient : IEntity
    {
        //We will add all the CLient specific properties here
        public string Name { get; set; }
    }
}
