using Easyvan.Data.Entity.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.Place
{
    public class Institution : ConfigurationEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public ICollection<InstitutionPhoneNumber> Phones { get; set; }
    }
}
