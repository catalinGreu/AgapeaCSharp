using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agapea.App_Code.controladores;
using Agapea.App_Code.modelos;
using Agapea.ControlesUsuario;

namespace Agapea
{
    public partial class VistaCesta : System.Web.UI.Page
    {
        private Controlador_Acceso_Ficheros __controlFichero;
        private ControladorTablas __controlTablas;
        private ControladorCesta __controlCesta;
        private string __cadenaISBN;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Libro> librosFichero;
            List<Libro> librosCesta = new List<Libro>();
            //List<Libro> librosCesta;
            __controlFichero = new Controlador_Acceso_Ficheros();

            librosFichero = __controlFichero.infoLibros("./Ficheros/libros.txt");

            try
            {
                foreach ( string isbn in readCookie() )
                {
                    foreach (Libro l in librosFichero)
                    {
                        if (l.ISBN10 == isbn)
                        {
                            librosCesta.Add(l);

                        }
                    }
                }
            }
            catch (Exception)
            {
                this.labelSubtotal.Text = "No has agregado libros.";

            }

            //CUTREZ!! Pero me queda una lista con los libros 
            //de la cesta de usuario
            __controlTablas = new ControladorTablas(this.Page);
            this.labelSubtotal.Text = __controlTablas.rellenaItems(librosCesta, this.tablaItems);
            //rellena la tabla con items y ademas me devuelve el precio total;
        }
        public string[] readCookie()
        {
            __cadenaISBN = (string)Request.Cookies["cesta"]["libros"];
            __cadenaISBN = __cadenaISBN.Substring(0, __cadenaISBN.Length - 1);
            //le quito ':' del final

            string[] isbnLibro = __cadenaISBN.Split(':');

            return isbnLibro;
        }
    }
}