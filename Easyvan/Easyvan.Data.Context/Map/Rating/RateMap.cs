using Easyvan.Data.Entity.Rating;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Rating
{
    public class RateMap : EntityTypeConfiguration<Rate>
    {
        public RateMap()
        {
            this.ToTable(typeof(Rate).Name);
            this.HasKey(x => x.Id);
        }
    }
}
