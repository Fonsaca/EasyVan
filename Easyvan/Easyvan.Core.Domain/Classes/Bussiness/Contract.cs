using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Classes.People;
using Easyvan.Core.Domain.Classes.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Classes.Bussiness
{
    public class Contract: BaseObject
    {
        public Passenger Passenger { get; set; }
        public Vehicle TransportVehicle { get; set; }
        public Owner Hired { get; set; }
        public short PaymentDay { get; set; }
        public double Value { get; set; }
        
        //TODO: Template definition
    }
}
