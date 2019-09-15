using Easyvan.Core.Domain.Classes.Bussiness;
using System.Collections.Generic;

namespace Easyvan.Core.Domain.Classes.People
{
    public class Client : Person
    {
        public bool ClientIsPassenger { get; set; }
        public ICollection<Passenger> Dependants { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}
