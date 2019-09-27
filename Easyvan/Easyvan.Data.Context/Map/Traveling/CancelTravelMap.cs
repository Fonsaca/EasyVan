using Easyvan.Data.Entity.Traveling;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Traveling
{
    public class CancelTravelMap : EntityTypeConfiguration<CancelTravel>
    {
        public CancelTravelMap()
        {
            this.ToTable(typeof(CancelTravel).Name);
            this.HasKey(x => x.Id);
        }
    }
}
