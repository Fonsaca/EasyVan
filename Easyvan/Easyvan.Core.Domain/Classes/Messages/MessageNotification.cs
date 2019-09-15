using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Classes.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Classes.Messages
{
    public class MessageNotification : BaseObject
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime SendTime { get; set; }
        public Person Sender { get; set; }
        public ICollection<Person> Recipients { get; set; }
    }
}
