using Easyvan.Data.Entity.Vehicles;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Vehicles
{
    public class VehicleMap : EntityTypeConfiguration<Vehicle>
    {
        public VehicleMap()
        {
            this.ToTable(typeof(Vehicle).Name);
            this.HasKey(x => x.Plate);
            this.HasOptional(x => x.Driver).WithOptionalDependent(x => x.Vehicle);
        }
    }
}
