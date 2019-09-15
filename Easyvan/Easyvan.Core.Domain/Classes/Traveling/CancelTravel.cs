using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Classes.People;
using System;

namespace Easyvan.Core.Domain.Classes.Traveling
{
    public class CancelTravel : BaseObject
    {
        public DateTime Date { get; set; }
        public Passenger Passenger { get; set; }
    }
}
