using Easyvan.Data.Entity.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.Vehicles
{
    public class Vehicle : ConfigurationEntity
    {
        int Id { get; set; }
        public Owner Owner { get; set; }
        public Driver Driver { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public short Seats { get; set; }
    }
}
