using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity
{
    public class ConfigurationEntity
    {
        public bool? Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
    }
}
