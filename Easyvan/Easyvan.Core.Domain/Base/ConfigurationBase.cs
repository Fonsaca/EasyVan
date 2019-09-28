﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Base
{
    public abstract class ConfigurationBase : BaseObject
    {
        public bool? Active { get; set; }

        public void Delete() {
            this.Active = null;
        } 


    }
}