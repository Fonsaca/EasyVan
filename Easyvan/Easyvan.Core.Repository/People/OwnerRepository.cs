using System.Collections.Generic;
using Easyvan.Core.Domain.Classes.People;
using Easyvan.Core.Interface.Repository.People;
using Easyvan.Data.Context.Context;
using System.Linq;
using Easyvan.Core.Repository.Mapper.People;

namespace Easyvan.Core.Repository.People
{
    public class OwnerRepository : IOwnerRepository
    {
        private DatabaseContext _context = new DatabaseContext();

        public Owner Create(Owner model)
        {
            var res = _context.Owners.Add(model.ToEntity());
            _context.SaveChanges();
            return model;
        }

        public void Delete(Owner model)
        {
            throw new System.NotImplementedException();
        }

        public Owner Find(string email)
        {
            var entity = _context.Owners.FirstOrDefault(x => x.Email == email);
            return entity == null ? null : entity.ToDomain();
        }

        public IEnumerable<Owner> List()
        {
            throw new System.NotImplementedException();
        }

        public Owner Update(Owner model)
        {
            throw new System.NotImplementedException();
        }
    }
}