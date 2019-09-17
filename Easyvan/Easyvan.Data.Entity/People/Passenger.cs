using Easyvan.Data.Entity.Place;
using Easyvan.Data.Entity.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.People
{
    public class Passenger : Person
    {
        public Client Responsable { get; set; }
        public TimeSpan StartShiftTime { get; set; }
        public TimeSpan FinishShiftTime { get; set; }
        public int Shift { get; set; }
        public Address PickupAddress { get; set; }
        public Address DeliverAddress { get; set; }
        public Institution Institution { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
