using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Notification
{
    public enum NotificationMessageType
    {
        SUCCESS = 1000,
        INFO = 2000,
        WARNING = 3000,
        ERROR = 4000,
        FATAL = 5000,
        UNKNOWN = 99999
    }
}
