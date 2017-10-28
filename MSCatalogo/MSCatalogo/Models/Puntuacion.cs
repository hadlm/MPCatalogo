using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace MSCatalogo.Models
{
    public class Puntos
    {
        public int Codigo { set; get; }
        public double Puntuacion { set; get; }

        public string Serialize()
        {
            JavaScriptSerializer s = new JavaScriptSerializer();
            return s.Serialize(this);
        }
    }
}