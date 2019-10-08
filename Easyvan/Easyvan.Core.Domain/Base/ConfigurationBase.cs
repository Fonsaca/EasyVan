namespace Easyvan.Core.Domain.Base
{
    public abstract class ConfigurationBase : BaseObject
    {
        public bool? Active { get; set; }

        public void Delete() {
            this.Active = null;
        }

        public abstract void ValidateCreation();
        public abstract void ValidateUpdate();
    }
}
