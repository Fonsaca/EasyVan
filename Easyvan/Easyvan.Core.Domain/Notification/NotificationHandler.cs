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

        public void Clear() {
            this.Messages = new List<NotificationMessage>();
            this.IsValid = true;
        }
    }
}
