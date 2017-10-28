using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MSCatalogo.Models;
using Newtonsoft.Json;

namespace MSCatalogo.Controllers
{
    public class ConsultarInventarioController : ApiController
    {
        // POST api/ConsultarInventario
        public IHttpActionResult Post([FromBody]Consulta value)
        {
            Consulta r = JsonConvert.DeserializeObject<Consulta>(value.Serialize());
            return Json(r);
        }
    }
}
