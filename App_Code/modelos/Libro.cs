using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agapea.App_Code.modelos
{
    public class Libro
    {

        #region "getters_setters"
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Categoria { get; set; }
        public string ISBN10{ get; set; }
        public string ISBN13 { get; set; }
        public decimal Precio { get; set; }
        public string NumPag { get; set; }
        public string Resumen { get; set; }

        #endregion
    }


}