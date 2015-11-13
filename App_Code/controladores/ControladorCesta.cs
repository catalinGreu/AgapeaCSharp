using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agapea.App_Code.modelos;
using Agapea.App_Code.controladores;

namespace Agapea.App_Code.controladores
{
    public class ControladorCesta
    {
        private Controlador_Acceso_Ficheros __controlFichero;

        public ControladorCesta() { }

        public List<Libro> getLibrosPorISBN(string[] isbns, string ruta)
        {
            __controlFichero = new Controlador_Acceso_Ficheros();
            return __controlFichero.librosByISBN(isbns, ruta);
        }
    }
}