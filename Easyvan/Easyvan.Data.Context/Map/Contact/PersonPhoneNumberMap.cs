using Easyvan.Data.Entity.Contact;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Contact
{
    public class PersonPhoneNumberMap : EntityTypeConfiguration<PersonPhoneNumber>
    {
        public PersonPhoneNumberMap()
        {
            this.ToTable(typeof(PersonPhoneNumber).Name);
            this.HasKey(x => x.Id);
        }
    }
}
