using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Notification
{
    public class NotificationMessage
    {
        public NotificationMessageType Type { get; private set; }
        public string Message { get; private set; }

        public Exception Exception { get; private set; }


        public NotificationMessage(NotificationMessageType type, string message) {
            SetMessage(type, message);
        }

        public NotificationMessage(NotificationMessageType type, string message, Exception ex) {
            SetMessage(type, message);
            this.Exception = ex;
        }

        private void SetMessage(NotificationMessageType type, string message) {
            if (!Enum.IsDefined(typeof(NotificationMessageType), type))
                this.Type = NotificationMessageType.UNKNOWN;
            else
                this.Type = type;

            if (string.IsNullOrEmpty(message))
                this.Message = string.Empty;
            else
                this.Message = message;
        }
    }
}
