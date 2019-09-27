using Easyvan.Data.Entity.Place;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Place
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            this.ToTable(typeof(Address).Name);
            this.HasKey(x => x.Id);
        }
    }
}
