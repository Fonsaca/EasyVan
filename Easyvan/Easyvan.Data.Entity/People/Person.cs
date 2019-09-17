using Easyvan.Data.Entity.Contact;
using Easyvan.Data.Entity.Message;
using Easyvan.Data.Entity.Place;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.People
{
    public class Person : ConfigurationEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public virtual ICollection<PersonPhoneNumber> Phones { get; set; }
        public Address Address { get; set; }
        public virtual ICollection<Notification> Messages { get; set; }
    }
}
