using Easyvan.Core.Domain.Classes.People;
using Easyvan.Core.Interface.Domain;
using Easyvan.Core.Interface.Domain.People;

namespace Easyvan.Core.DomainService.People
{
    public class OwnerDomainService : DomainService, IOwnerDomainService
    {
        public bool Delete(Owner model)
        {
            return true;
        }

        public bool ValidConfigurationToInsert(Owner model)
        {
            return true;
        }

        public bool ValidConfigurationToUpdate(Owner model)
        {
            return true;
        }
    }
}
