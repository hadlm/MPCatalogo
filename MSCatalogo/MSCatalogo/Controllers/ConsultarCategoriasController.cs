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
    public class ConsultarCategoriasController : ApiController
    {
        // POST api/ConsultarCategorias
        public IHttpActionResult Post([FromBody]Categoria value)
        {
            RCategoria result = new Models.RCategoria();
            
            return Json(result);
        }
    }
}
