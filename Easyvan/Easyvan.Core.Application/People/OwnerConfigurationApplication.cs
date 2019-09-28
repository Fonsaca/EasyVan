using Easyvan.Core.Application.Configuration;
using Easyvan.Core.Domain.Classes.People;
using Easyvan.Core.DomainService.People;
using Easyvan.Core.Interface.Application.People;

namespace Easyvan.Core.Application.People
{
    public class OwnerConfigurationApplication : ConfigurationApplication<Owner, OwnerDomainService>, IOwnerConfigurationApplication
    {
        public OwnerConfigurationApplication() : base(new OwnerDomainService())
        {
        }
    }
}
