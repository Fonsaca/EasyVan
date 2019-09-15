using Easyvan.Core.Domain.Classes.People;
using Easyvan.Core.Domain.Classes.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Classes.Rating
{
    public class TransportRate : Rate
    {
        public Owner TransportOwner { get; set; }
    }
}
