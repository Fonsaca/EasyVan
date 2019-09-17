using Easyvan.Data.Entity.People;
using Easyvan.Data.Entity.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.Bussiness
{
    public class Contract : ConfigurationEntity
    {
        public int Id { get; set; }
        public Passenger Passenger { get; set; }
        public short PaymentDay { get; set; }
        public double Value { get; set; }

        public string Template { get; set; }
        public string ContractValue { get; set; }
    }
}
