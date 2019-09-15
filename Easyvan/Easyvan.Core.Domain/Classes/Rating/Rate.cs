using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Classes.People;
using Easyvan.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Classes.Rating
{
    public abstract class Rate : BaseObject
    {
        public short Satisfaction { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public Client RatedBy { get; set; }

    }
}
