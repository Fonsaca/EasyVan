using Easyvan.Data.Entity.Bussiness;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Bussiness
{
    public class ContractMap : EntityTypeConfiguration<Contract>
    {
        public ContractMap()
        {
            this.ToTable(typeof(Contract).Name);
            this.HasKey(x => x.Id);
        }
    }
}
