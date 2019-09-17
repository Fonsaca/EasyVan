using Easyvan.Data.Entity.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.Traveling
{
    public class CancelTravel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Passenger Passenger { get; set; }
    }
}
