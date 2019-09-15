using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Classes.People;
using System.Collections.Generic;

namespace Easyvan.Core.Domain.Classes.Traveling
{
    public class Route : BaseObject
    {
        public Driver Driver { get; set; }
        public ICollection<CancelTravel> Canceled { get; set; }
    }
}
