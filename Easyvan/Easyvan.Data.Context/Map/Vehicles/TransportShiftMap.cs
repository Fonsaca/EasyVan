using Easyvan.Data.Entity.Vehicles;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Vehicles
{
    public class TransportShiftMap : EntityTypeConfiguration<TransportShift>
    {
        public TransportShiftMap()
        {
            this.ToTable(typeof(TransportShift).Name);
            this.HasKey(x => x.Id);
        }
    }
}
