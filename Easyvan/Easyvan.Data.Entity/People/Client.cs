using System.Collections.Generic;

namespace Easyvan.Data.Entity.People
{
    public class Client : Person
    {
        public ICollection<Passenger> Dependants { get; set; }
    }
}
