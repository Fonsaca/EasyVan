using Easyvan.Data.Entity.People;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.People
{
    public class PassengerMap : EntityTypeConfiguration<Passenger>
    {
        public PassengerMap()
        {
            this.ToTable(typeof(Passenger).Name);
            this.HasKey(x => x.Id);
        }
    }
}
