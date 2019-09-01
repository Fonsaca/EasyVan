using Easyvan.Core.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Base
{
    public abstract class BaseObject
    {
        public readonly NotificationHandler Notification;
        protected BaseObject() {
            this.Notification = new NotificationHandler();
        }
    }
}
