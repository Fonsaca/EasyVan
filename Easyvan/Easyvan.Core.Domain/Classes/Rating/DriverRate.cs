using Easyvan.Core.Domain.Classes.People;

namespace Easyvan.Core.Domain.Classes.Rating
{
    public class DriverRate : Rate
    {
        public Driver Driver { get; set; }
    }
}
