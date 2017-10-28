using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MSCatalogo.Models;

namespace MSCatalogo.Controllers
{
    public class PuntuarProductoController : ApiController
    {
        // POST api/PuntuarProducto
        public IHttpActionResult Post([FromBody]Puntos value)
        {
            RPuntuacion result = new RPuntuacion();
            return Json(result);
        }
    }
}
