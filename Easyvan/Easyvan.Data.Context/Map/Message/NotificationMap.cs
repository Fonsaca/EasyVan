using Easyvan.Data.Entity.Message;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.Message
{
    public class NotificationMap : EntityTypeConfiguration<Notification>
    {
        public NotificationMap()
        {
            this.ToTable(typeof(Notification).Name);
            this.HasKey(x => x.Id);
        }
    }
}
