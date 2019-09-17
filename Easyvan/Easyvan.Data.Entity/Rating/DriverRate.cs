using Easyvan.Data.Entity.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.Rating
{
    public class DriverRate : Rate
    {
        public Driver Driver { get; set; }
    }
}
