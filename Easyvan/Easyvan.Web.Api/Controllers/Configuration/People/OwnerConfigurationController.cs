using Easyvan.Core.Application.People;
using Easyvan.Core.Domain.Classes.People;
using Easyvan.Core.Interface.Application.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Easyvan.Web.Api.Controllers
{

    [RoutePrefix("api/OwnerConfiguration")]
    public class OwnerConfigurationController : ApiController
    {

        private readonly IOwnerConfigurationApplication application;
        public OwnerConfigurationController()
        {
            application = new OwnerConfigurationApplication();
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Testing()
        {
            try
            {
                this.application.Create(new Owner());
            }
            catch(Exception ex)
            {

            }


            return Ok();
        }

    }
}
