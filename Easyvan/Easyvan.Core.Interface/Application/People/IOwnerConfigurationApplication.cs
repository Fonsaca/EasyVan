using Easyvan.Core.Domain.Classes.People;
using Easyvan.Core.Interface.Domain.People;

namespace Easyvan.Core.Interface.Application.People
{
    public interface IOwnerConfigurationApplication : IConfigurationApplication<Owner, IOwnerDomainService>
    {
    }
}
