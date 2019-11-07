using Easyvan.Core.Domain.Classes.People;
using System.Collections.Generic;

namespace Easyvan.Core.Interface.Application.People
{
    public interface IOwnerConfigurationApplication : IConfigurationApplication<Owner>
    {
        Owner FindByEmail(string email);
    }
}
