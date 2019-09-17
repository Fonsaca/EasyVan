using Easyvan.Data.Entity.People;
using Easyvan.Data.Entity.Place;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.Contact
{
    public class InstitutionPhoneNumber
    {
        public Institution Contact { get; set; }
        public string Number { get; set; }
    }
}
