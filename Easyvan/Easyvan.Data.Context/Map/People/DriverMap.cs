using Easyvan.Data.Entity.People;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.People
{
    public class DriverMap : EntityTypeConfiguration<Driver>
    {
        public DriverMap()
        {
            this.ToTable(typeof(Driver).Name);
            this.HasKey(x => x.Id);
        }
    }
}
