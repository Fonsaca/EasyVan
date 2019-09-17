using Easyvan.Data.Entity.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.People
{
    public class Client : Person
    {
        public ICollection<Passenger> Dependants { get; set; }
    }
}
