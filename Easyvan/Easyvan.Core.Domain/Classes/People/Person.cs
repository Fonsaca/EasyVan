using Easyvan.Core.Domain.Base;
using Easyvan.Core.Domain.Classes.Messages;
using Easyvan.Core.Domain.Classes.Place;
using Easyvan.Core.Domain.Interfaces;
using Easyvan.Core.Domain.Notification;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Easyvan.Core.Domain.Classes.People
{
    public abstract class Person : ConfigurationBase , IDomain
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Address HomeAddress { get; set; }
        public ICollection<string> Phones { get; set; }
        public ICollection<MessageNotification> Messages {get;set;}

        
        private bool ValidateFullName(){
            Regex pattern = new Regex(@"/^[a-zA-Z\s']*$/");
            if (string.IsNullOrEmpty(FullName)) {
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Nome não informado");
            }else if (!pattern.IsMatch(FullName)) {
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Nome invalido. Deve conter apenas letras e espaço");
            } else {
                return true;
            }
            return false;
        }

        private bool ValidateEmail() {
            Regex pattern = new Regex(@"/^[a-z0-9.]+@[a-z0-9]+\.[a-z]+\.([a-z]+)?$/i");
            if (string.IsNullOrEmpty(Email)) {
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Email não informado");
            } else if (!pattern.IsMatch(Email)) {
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Email possui formato invalido");
            } else {
                return true;
            }
            return false;
        }

        private bool ValidateCPF() {
            Regex pattern = new Regex(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})");
            if (string.IsNullOrEmpty(CPF)) {
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "CPF não informado");
            } else if (!pattern.IsMatch(CPF)) {
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "CPF possui formato invalido");
            } else {
                return true;
            }
            return false;
        }

        private bool ValidateRG() {
            //Regex pattern = new Regex(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})");
            if (string.IsNullOrEmpty(CPF)) {
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "RG não informado");
            //} else if (!pattern.IsMatch(CPF)) {
            //    this.Notification.AddMessage(false, NotificationMessageType.ERROR, "CPF possui formato invalido");
            } else {
                return true;
            }
            return false;
        }

        private bool ValidatePhones() {
            if (Phones == null || !Phones.Any()) {
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Informe pelo menos um numero para contato");
            } else {
                return true;
            }
            return false;
        }

        private bool ValidateHomeAddress() {
            if(this.HomeAddress == null) {
                this.Notification.AddMessage(false, NotificationMessageType.ERROR, "Endereço não informado");
            } else {
                return true;
            }
            return false;
        }

        public bool ValidateNewPerson() {
            return this.ValidateFullName() && this.ValidateEmail()
                && this.ValidateCPF() && this.ValidateRG() && this.ValidatePhones()
                && this.ValidateHomeAddress();
        }

    }
}
