using Easyvan.Data.Entity.Place;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Place
{
    public class InstitutionMap : EntityTypeConfiguration<Institution>
    {
        public InstitutionMap()
        {
            this.ToTable(typeof(Institution).Name);
            this.HasKey(x => x.Id);
        }
    }
}
