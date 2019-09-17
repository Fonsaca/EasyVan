using Easyvan.Data.Entity.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.Rating
{
    public class Rate : ConfigurationEntity
    {
        public int Id { get; set; }
        public short Satisfaction { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public Client RatedBy { get; set; }

    }
}
