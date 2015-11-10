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
    public partial class MyInicio : System.Web.UI.Page
    {
        private Controlador_Vista_Inicio __controlInit;
        private ControladorTablas __controlTabla;
        private string __categoriaPulsada;
        private List<Libro> librosFichero;
        private const string __rutaControlLibro = "~/ControlesUsuario/MiniLibro.ascx";
        private const string __rutaControlDetalles = "~/ControlesUsuario/MiniDetallesLibro.ascx";
       
        protected void Page_Load(object sender, EventArgs e)
        {
            #region "controles de la Master"
            ImageButton ButtonCompra = (ImageButton)this.Master.FindControl("ButtonCompra");
            Label LabelUser = (Label)this.Master.FindControl("LabelUser");
            TreeView myTreeView = (TreeView)this.Master.FindControl("myTreeView");
            #endregion
            
            __controlInit = new Controlador_Vista_Inicio();
            __controlTabla = new ControladorTablas(this.Page);

            librosFichero = __controlInit.infoLibros("./Ficheros/libros.txt");

            #region "sesionUser"
            if (this.Session["Usuario"] != null)
            {
                LabelUser.Text = (string)Session["Usuario"];
            }
            else
            {
                LabelUser.Text = "Parece que el nombre no se almacena bien";
            }

            ///---llamada a procedimiento interno para ver variables post

            #endregion

            mostrar();

            #region "isPostback"
            if (this.IsPostBack)
            {

                foreach (string clave in this.Request.Params.AllKeys)
                {
                    string claveRequest = this.Request.Params[clave];
                    switch (clave)
                    {

                        case "__EVENTTARGET":

                            if (claveRequest.Contains(myTreeView.ID))
                            {
                                char[] separador = new char[] { '\\' };
                                __categoriaPulsada = this.Request.Params["__EVENTARGUMENT"].ToString().Split(separador)[0].Substring(1);
                                LabelUser.Text = "has seleccionado el nodo treeview: " + __categoriaPulsada;
                                //metodo que devuelve libros con categorías....

                                if (__categoriaPulsada == "Todos")

                                    __controlTabla.rellenaTablaLibros(this.tablaLibros, librosFichero, false);

                                List<Libro> categoryList = __controlInit.findByCategory(librosFichero, __categoriaPulsada);

                                __controlTabla.rellenaTablaLibros(this.tablaLibros, categoryList, true);
                            }

                            else if (claveRequest.Contains("linkButtonTitulo"))
                            {
                                string isbnLibro = ((string)claveRequest).Substring(((string)claveRequest).Length - 10, 10);
                                Response.Redirect("VistaDetallesLibro.aspx?isbn=" + isbnLibro);
                            }

                            else if (claveRequest.Contains("botonCompra"))
                            {

                            }
                            break;

                        default:
                            break;
                    }
                }
            }
            #endregion
            else
            {
                __controlTabla.rellenaTablaLibros(this.tablaLibros, librosFichero, false);
               
            }

        }
       
        private void mostrar()
        {
            string mensaje = "";
            foreach (string clave in this.Request.Params.Keys)
            {
                mensaje += "clave:_" + clave + " -------valor:_" +
                    this.Request.Params[clave].ToString() + "\n";
            }
            this.TextBox1.Text = mensaje;
        }
    }
}
