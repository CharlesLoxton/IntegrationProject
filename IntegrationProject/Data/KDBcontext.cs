using IntegrationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Data
{
    internal class KDBcontext
    {
        //This is only for simulating, the actual context class in EF core looks different.
        public Database Database;
        public string Provider { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;

        public List<APLink> APLink = new List<APLink>();

        public KDBcontext() 
        {
            Database = new Database();
        }

        public void SaveChanges()
        {
            Console.WriteLine("Creating Entity Completed");
            Console.WriteLine("\n");
        }
    }
}
