
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Repository.Mapper.People
{
    public static class OwnerMapper
    {
        public static Domain.Classes.People.Owner ToDomain(this Data.Entity.People.Owner entity, Domain.Classes.People.Owner result = null)
        {
            if (result == null)
                result = new Domain.Classes.People.Owner();

            result.Active = entity.Active;
            result.CNPJ = entity.CNPJ;
            result.CPF = entity.CPF;
            result.Email = entity.Email;
            result.FullName = entity.FullName;
            result.RG = entity.RG;
            result.Phones = entity.Phones.Select(x => x.Number).ToList();

            //result.Vehicles = entity.Active;
            //result.TransportLicense = entity.Active;
            //result.Clients = entity.Active;
            //result.DriverEmployees = entity.Active;
            //result.HomeAddress = entity.Active;

            return result;
        }

        public static Data.Entity.People.Owner ToEntity(this Domain.Classes.People.Owner model, Data.Entity.People.Owner result = null)
        {
            if(result == null)
                result = new Data.Entity.People.Owner();

            result.Active = model.Active;
            result.CNPJ = model.CNPJ;
            result.CPF = model.CPF;
            result.Email = model.Email;
            result.FullName = model.FullName;
            result.RG = model.RG;

            //result.Phones = model.Phones.Select(x => x.Number).ToList();
            //result.Vehicles = entity.Active;
            //result.TransportLicense = entity.Active;
            //result.Clients = entity.Active;
            //result.DriverEmployees = entity.Active;
            //result.HomeAddress = entity.Active;

            return result;
        }
    }
}
