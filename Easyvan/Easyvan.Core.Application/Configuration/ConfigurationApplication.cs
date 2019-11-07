using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Notification;
using Easyvan.Core.Interface.Application;
using Easyvan.Core.Interface.Domain;
using Easyvan.Core.Interface.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Easyvan.Core.Application.Configuration
{
    public class ConfigurationApplication<D, S, R> : Application, IConfigurationApplication<D>
        where D : ConfigurationBase
        where S : IConfigurationDomainService<D>
        where R : IConfigurationRepository<D>
    {
        protected readonly S _service;
        protected readonly R _repository;

        public ConfigurationApplication(S service, R repository)
        {
            this._service = service;
            this._repository = repository;
            if (_service == null)
                this.Notification.AddMessage(false, NotificationMessageType.FATAL, string.Format("Domain service '{0}' não foi instanciado", typeof(S).Name));
            if (_repository == null)
                this.Notification.AddMessage(false, NotificationMessageType.FATAL, string.Format("Repository '{0}' não foi instanciado", typeof(R).Name));
        }

        public D Create(D model)
        {
            if (model == null)
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "É preciso informar uma configuração para inserir-la");

            if (!this.Notification.IsValid)
                return model;

            model.ValidateCreation();
            if (!model.Notification.IsValidMessage(this.Notification))
                return model;
            

            if (!this._service.ValidConfigurationToInsert(model)) {
                this.Notification.AddMessage(false, model.Notification.Messages.LastOrDefault());
                return model;
            }

            return this._repository.Create(model);
        }

        public void Delete(D model)
        {
            if (model == null)
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "É preciso informar a configuração para exclui-la");

            if (!this.Notification.IsValid)
                return;

            if (!this._service.Delete(model)){
                this.Notification.AddMessage(false, model.Notification.Messages.LastOrDefault());
                return;
            }

            this._repository.Delete(model);
        }

        public D Edit(D model)
        {
            if (model == null)
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "É preciso informar a configuração para altera-la");

            if (!this.Notification.IsValid)
                return model;

            model.ValidateUpdate();
            if (!model.Notification.IsValidMessage(this.Notification))
                return model;


            if (!this._service.ValidConfigurationToUpdate(model))
            {
                this.Notification.AddMessage(false, model.Notification.Messages.LastOrDefault());
                return model;
            }

            return this._repository.Create(model);
        }

        public IEnumerable<D> List()
        {
            if (!this.Notification.IsValid)
                return new List<D>();

            return this._repository.List();
        }
    }
}
