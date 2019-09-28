using Easyvan.Core.Domain.Classes.People;
using Easyvan.Core.Interface.Domain;
using Easyvan.Core.Interface.Domain.People;

namespace Easyvan.Core.DomainService.People
{
    public class OwnerDomainService : DomainService, IOwnerDomainService
    {
        public bool Delete(Owner model)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidConfigurationToInsert(Owner model)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidConfigurationToUpdate(Owner model)
        {
            throw new System.NotImplementedException();
        }
    }
}
