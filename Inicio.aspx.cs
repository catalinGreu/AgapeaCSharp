using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agapea.App_Code.controladores;
using Agapea.App_Code.modelos;
namespace Agapea
{
    public partial class Inicio : System.Web.UI.Page
    {

        private Controlador_Vista_Inicio __controlInit;

        protected void Page_Load(object sender, EventArgs e)

        {
            this.LabelUser.Text = (string) this.Request.QueryString["Usuario"];
            ///---llamada a procedimiento interno para ver variables post

            mostrar();
            if (this.IsPostBack)
            {
                foreach (string clave in this.Request.Params.AllKeys)
                {
                    if ( clave == this.ButtonCompra.ID)
                    {
                        this.LabelUser.Text = "HAS PULSADO EL BOTON!!";
                    }
                }
                
            }
            __controlInit = new Controlador_Vista_Inicio();

            List<Libro> librosFichero = __controlInit.infoLibros("./Ficheros/libros.txt");
            //Devuelve una lista de libros...con sus atributos cargados.

            foreach (Libro l in librosFichero)
            {
                TableCell cell = new TableCell();
                TableRow row = new TableRow();
                tablaLibros.Rows.Add(row);

                row.Cells.Add(cell);

                try
                {
                    cell.Controls.Add(new Label() { Text = "Titulo: " + l.Titulo + "\n" + "Autor: " + l.Autor });
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void mostrar()
        {
            string mensaje = "";
            foreach (string clave in this.Request.Params.Keys )
            {
                mensaje += "clave:_" + clave + " -------valor:_" + 
                    this.Request.Params[clave].ToString() + "\n";
            }
            this.TextBox1.Text = mensaje;
        }
    }
}