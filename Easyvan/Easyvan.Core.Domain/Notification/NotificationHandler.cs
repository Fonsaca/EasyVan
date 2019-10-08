using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Notification
{
    public class NotificationHandler
    {
        
        public ICollection<NotificationMessage> Messages { get; private set; }
        public bool IsValid { get; private set; }

        public NotificationHandler() {
            this.Messages = new List<NotificationMessage>();
            this.IsValid = true;
        }

        public void AddMessage(bool valid, NotificationMessageType type, string message) {
            this.IsValid = valid;
            this.Messages.Add(new NotificationMessage(type, message));
        }

        public void AddMessage(bool valid, NotificationMessageType type, string message, Exception ex) {
            this.IsValid = valid;
            this.Messages.Add(new NotificationMessage(type, message,ex));
        }

        public void AddMessage(bool valid, NotificationMessage message)
        {
            this.IsValid = valid;
            this.Messages.Add(message ?? new NotificationMessage(NotificationMessageType.FATAL,"Erro inesperado",null));
        }

        public bool IsValidMessage(NotificationHandler destination)
        {
            if (this.IsValid)
                return true;

            destination.IsValid = false;
            destination.Messages.Add(this.Messages.LastOrDefault());
            return false;
        }

        public void Clear() {
            this.Messages = new List<NotificationMessage>();
            this.IsValid = true;
        }
    }
}
