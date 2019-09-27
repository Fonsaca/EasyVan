using Easyvan.Data.Entity.Contact;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Contact
{
    public class InstitutionPhoneNumberMap : EntityTypeConfiguration<InstitutionPhoneNumber>
    {
        public InstitutionPhoneNumberMap()
        {
            this.ToTable(typeof(InstitutionPhoneNumber).Name);
            this.HasKey(x => x.Id);
        }
    }
}
