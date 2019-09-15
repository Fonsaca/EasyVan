using Easyvan.Core.Domain.Classes.Vehicles;
using Easyvan.Core.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Classes.People
{
    public class Driver: Person
    {
        public string CNH { get; set; }
        public Vehicle Vehicle { get; set; }
        public Owner Hirer { get; set; }
        public ICollection<Passenger> Passengers { get; set; }

        private bool ValidateLicense() {
            if (string.IsNullOrEmpty(CNH))
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "CNH não informada");
            else
                return true;
            return false;
        }
    }
}
