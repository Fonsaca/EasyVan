using Easyvan.Data.Entity.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.People
{
    public class Driver : Person
    {
        public string CNH { get; set; }
        public Vehicle Vehicle { get; set; }
        public Owner Hirer { get; set; }
    }
}
