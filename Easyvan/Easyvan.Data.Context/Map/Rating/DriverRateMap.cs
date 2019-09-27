using Easyvan.Data.Entity.Rating;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Rating
{
    public class DriverRateMap : EntityTypeConfiguration<DriverRate>
    {
        public DriverRateMap()
        {
            this.ToTable(typeof(DriverRate).Name);
            this.HasKey(x => x.Id);
        }
    }
}
