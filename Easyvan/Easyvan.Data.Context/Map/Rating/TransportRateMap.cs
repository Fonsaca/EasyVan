using Easyvan.Data.Entity.Rating;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Rating
{
    public class TransportRateMap : EntityTypeConfiguration<TransportRate>
    {
        public TransportRateMap()
        {
            this.ToTable(typeof(TransportRate).Name);
            this.HasKey(x => x.Id);
        }
    }
}
