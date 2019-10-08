using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Notification;
using System.Collections.Generic;

namespace Easyvan.Core.Interface.Domain
{
    public interface IConfigurationDomainService<T>: IService where T : ConfigurationBase
    {
        bool ValidConfigurationToInsert(T model);
        bool ValidConfigurationToUpdate(T model);
        bool Delete(T model);
    }
}
