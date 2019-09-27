using Easyvan.Data.Entity.People;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.People
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            this.ToTable(typeof(Person).Name);
            this.HasKey(x => x.Id);
        }
    }
}
