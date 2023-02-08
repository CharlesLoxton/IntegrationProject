using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Data
{
    internal class Database
    {
        public string CurrentTransaction { get; set; } = string.Empty;

        public Transaction BeginTransaction()
        {
            return new Transaction();
        }
    }
}
