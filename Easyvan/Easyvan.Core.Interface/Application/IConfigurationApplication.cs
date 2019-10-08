using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Interfaces;
using Easyvan.Core.Interface.Domain;
using System.Collections.Generic;

namespace Easyvan.Core.Interface.Application
{
    public interface IConfigurationApplication<D> : IService 
        where D : ConfigurationBase
    {
        D Create(D model);
        D Edit(D model);
        void Delete(D model);
        IEnumerable<D> List();
    }
}
