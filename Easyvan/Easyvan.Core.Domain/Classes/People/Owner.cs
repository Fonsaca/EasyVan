using Easyvan.Core.Domain.Classes.Vehicles;
using Easyvan.Core.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Classes.People
{
    public class Owner : Person
    {
        public string CNPJ { get; set; }
        public string TransportLicense { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Driver> DriverEmployees { get; set; }
        private bool ValidateLicense() {
            if (string.IsNullOrEmpty(TransportLicense))
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Alvara não informado");
            else
                return true;
            return false;
        }
    }
}
