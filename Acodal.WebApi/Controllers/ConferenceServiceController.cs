using Acodal.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Acodal.WebApi.Controllers
{
    public class ConferenceServiceController : ApiController
    {
        ConferenceServiceModel CsModel = new ConferenceServiceModel(); 

        [HttpGet]
        [Route("API/ConferenceService/GetConferences")]
        public IHttpActionResult GetConferences() {
                var model = CsModel.ManagerCB.GetConferences(null);
                return Json(model);
        }


        [HttpGet]
        [Route("API/ConferenceService/Valor")]
        public IHttpActionResult Valor() {
            return Ok("algo");
        }

        [HttpPost]
        [Route("API/ConferenceService/GetConferencesByHour")]
        public IHttpActionResult GetConferencesByHour([FromBody]string hora) {
            var model = CsModel.ManagerCB.GetConferencesByHour(Convert.ToDateTime(hora));
            return Json(model);
        }
    }
}
