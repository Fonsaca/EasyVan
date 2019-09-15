using Easyvan.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Classes.Place
{
    public class Institution : BaseObject
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public ICollection<string> Phones { get; set; }
    }
}
