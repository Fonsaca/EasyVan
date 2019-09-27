using Easyvan.Data.Entity.People;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.People
{
    public class OwnerMap : EntityTypeConfiguration<Owner>
    {
        public OwnerMap()
        {
            this.ToTable(typeof(Owner).Name);
            this.HasKey(x => x.Id);
        }
    }
}
