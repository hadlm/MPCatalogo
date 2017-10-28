using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace MSCatalogo.Models
{
    public class Consulta
    {
        public int Categoria {set; get;}
        public int Mas_vendidos {set; get;}
        public string Fecha_inicio {set; get;}
        public string Fecha_fin {set; get;}
        public int Producto_ofertado { set; get; }

        public string Serialize() {
            JavaScriptSerializer s = new JavaScriptSerializer();
            return s.Serialize(this);
        }

    }
}