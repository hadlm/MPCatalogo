using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSCatalogo.Models
{
    public class DCategoria {
        public int Codigo { set; get; }
        public string Nombre { set; get; }
    }

    public class RCategoria
    {
        public int Resultadio { set; get; }
        public DCategoria[] Categorias;
    }
}