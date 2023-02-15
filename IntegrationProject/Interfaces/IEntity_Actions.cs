using IntegrationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Interfaces
{
    internal interface IEntity_Actions
    {
        void Upsert(IEntity entity);
        void Delete(int accountingProviderId);
        void Sync();
    }
}
