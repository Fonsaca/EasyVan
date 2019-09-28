using Easyvan.Core.Domain.Interfaces;
using Easyvan.Core.Domain.Notification;
using System;
using System.Collections.Generic;

namespace Easyvan.Core.Interface
{
    public interface IService
    {
        Tuple<bool, ICollection<NotificationMessage>> ValidStatus { get; }
    }
}
