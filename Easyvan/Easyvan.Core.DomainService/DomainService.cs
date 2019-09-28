using Easyvan.Core.Domain.Notification;
using Easyvan.Core.Interface;
using System;
using System.Collections.Generic;

namespace Easyvan.Core.DomainService
{
    public abstract class DomainService : IService
    {
        public readonly NotificationHandler Notification;
        protected DomainService()
        {
            this.Notification = new NotificationHandler();
        }
        public Tuple<bool, ICollection<NotificationMessage>> ValidStatus {
            get{
                return new Tuple<bool, ICollection<NotificationMessage>>(this.Notification.IsValid, this.Notification.Messages);
            }
        }
    }
}
