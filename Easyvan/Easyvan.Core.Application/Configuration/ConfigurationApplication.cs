using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Interfaces;
using Easyvan.Core.Domain.Notification;
using Easyvan.Core.Interface.Application;
using Easyvan.Core.Interface.Domain;
using System;
using System.Collections.Generic;

namespace Easyvan.Core.Application.Configuration
{
    public class ConfigurationApplication<D, S> : Application, IConfigurationApplication<D, S>
        where D : ConfigurationBase
        where S : IConfigurationDomainService<D>
    {
        private readonly S _service;

        public ConfigurationApplication(S service)
        {
            this._service = service;
        }

        public D Create(D model)
        {
            if (model == null)
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Não é possivel criar uma configuração vazia");
            else if(_service == null)
                this.Notification.AddMessage(false, NotificationMessageType.FATAL, string.Format("Domain service '{0}' não foi instanciado",typeof(S).Name));

            if (!this.Notification.IsValid)
                return null;

            throw new NotImplementedException();
        }

        public void Delete(D model)
        {
            throw new NotImplementedException();
        }

        public D Edit(D model)
        {
            throw new NotImplementedException();
        }

        public ICollection<D> List()
        {
            throw new NotImplementedException();
        }
    }
}
