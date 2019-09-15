using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Classes.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Classes.Vehicles
{
    public class Vehicle: BaseObject
    {
        public Owner Owner { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public short Seats { get; set; }
    }
}
