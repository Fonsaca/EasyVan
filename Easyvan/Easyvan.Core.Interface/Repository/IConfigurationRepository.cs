using Easyvan.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Interface.Repository
{
    public interface IConfigurationRepository<D> where D : ConfigurationBase
    {
        D Create(D model);
        D Update(D model);
        void Delete(D model);
        IEnumerable<D> List();
    }
}
