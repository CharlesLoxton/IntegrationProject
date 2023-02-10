using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Interfaces
{
    internal interface IEntity
    {
        //These are properties that are universal for all entities
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Guid { get; set; }
    }
}
