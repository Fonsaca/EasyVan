using Easyvan.Data.Entity.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Data.Entity.Message
{
    public class Notification
    {
        public Person Sender { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime SendTime { get; set; }
        public virtual ICollection<Person> Recipients { get; set; }
    }
}
