using IntegrationProject.API;
using IntegrationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Visitors
{
    internal class API_Visitor : IAPI_Visitor
    {
        public IAPI_Actions? Result { get; private set; }
        private IEntity entity;
        private string provider;

        public API_Visitor(IEntity entity, string provider)
        {
            this.entity = entity;
            this.provider = provider;
        }

        public void Visit(IAPI_Actions api)
        {
            if (Result == null && api.IsMatch(entity, provider))
            {
                Result = api;
            }
        }
    }
}
