using Easyvan.Core.Domain.Classes.Place;
using Easyvan.Core.Domain.Enums;
using Easyvan.Core.Domain.Notification;
using System;

namespace Easyvan.Core.Domain.Classes.People
{
    public class Passenger : Person
    {
        public Client Responsable { get; set; }
        public TimeSpan StartShiftTime { get; set; }
        public TimeSpan FinishShiftTime { get; set; }
        public TransportShiftEnum Shift { get; set; }
        public Address PickupAddress { get; set; }
        public Address DeliverAddress { get; set; }
        public Institution Institution { get; set; }

        private bool ValidateShift() {
            if (!Enum.IsDefined(typeof(TransportShiftEnum), Shift))
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Turno não informado");
            else
                return true;

            return false;
        }

        private bool ValidateAddress() {
            if (PickupAddress == null)
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Endereço de embarque não informado");
            else if(this.DeliverAddress == null) {
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Endereço de entrega não informado");
            }else
                return true;

            return false;
        }
    }
}
