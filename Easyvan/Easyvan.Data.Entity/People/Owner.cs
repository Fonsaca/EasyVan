using Easyvan.Data.Entity.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.People
{
    public class Owner : Person
    {
        public string CNPJ { get; set; }
        public string TransportLicense { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Driver> Drivers { get; set; }
    }
}
