using Easyvan.Data.Entity.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.Contact
{
    public class PersonPhoneNumber
    {
        public int Id { get; set; }
        public Person Contact { get; set; }
        public string Number { get; set; }
    }
}
