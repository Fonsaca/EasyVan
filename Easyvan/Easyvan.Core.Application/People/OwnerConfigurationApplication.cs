using Easyvan.Core.Application.Configuration;
using Easyvan.Core.Domain.Classes.People;
using Easyvan.Core.DomainService.People;
using Easyvan.Core.Interface.Application.People;
using Easyvan.Core.Interface.Domain.People;
using Easyvan.Core.Interface.Repository.People;
using Easyvan.Core.Repository.People;

namespace Easyvan.Core.Application.People
{
    public class OwnerConfigurationApplication : ConfigurationApplication<Owner, IOwnerDomainService,IOwnerRepository>, IOwnerConfigurationApplication
    {
        public OwnerConfigurationApplication() : base(new OwnerDomainService(), new OwnerRepository())
        {
        }
    }
}
