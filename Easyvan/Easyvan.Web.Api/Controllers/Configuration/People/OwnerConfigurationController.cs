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

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(Owner model)
        {
            try
            {
                this.application.Create(model);
            }
            catch(Exception ex)
            {
                return InternalServerError();
            }
            return Ok();
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Find(string email)
        {
            try
            {
                return Ok(this.application.FindByEmail(email));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

    }
}
