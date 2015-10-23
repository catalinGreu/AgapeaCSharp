using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agapea.App_Code.controladores;
using Agapea.App_Code.modelos;
using Agapea.App_Code.Controles_Personalizados;
namespace Agapea
{
    public partial class Inicio : System.Web.UI.Page
    {

        private Controlador_Vista_Inicio __controlInit;
        private string __categoriaPulsada;
        private List<Libro> librosFichero;
        //MiniControlLibro __micontrol;
        protected void Page_Load(object sender, EventArgs e)

        {          

            __controlInit = new Controlador_Vista_Inicio();

            

            librosFichero = __controlInit.infoLibros("./Ficheros/libros.txt");

            #region "sesionUser"
            if (Session["Usuario"] != null)
            {
                var nombreUser = (string)Session["Usuario"];
                this.LabelUser.Text = nombreUser;
            }
            else
            {
                this.LabelUser.Text = "Parece que el nombre no se almacena bien";
            }

            ///---llamada a procedimiento interno para ver variables post
            mostrar();
            #endregion


            #region "isPostback"

            if (this.IsPostBack)
            {//si quiero comprobar que botones se pulsan siempre necesitare un isPostBack.

                foreach (string clave in this.Request.Params.AllKeys)
                {
                    if (clave == this.ButtonCompra.ID)
                    {
                        this.LabelUser.Text = "HAS PULSADO EL BOTON!!";
                    }
                    else if (clave == "__EVENTTARGET" && this.Request.Params[clave] == this.myTreeView.ID)
                    {
                        //si seleccion algo del treeView asigno la categoría a la variable
                        this.__categoriaPulsada = this.Request.Params["__EVENTARGUMENT"].ToString().Split(new char[] { '\\' })[1];
                        this.LabelUser.Text = "has seleccionado el nodo treeview: " + __categoriaPulsada;
                        //metodo que devuelve libros con categorías....

                        if (__categoriaPulsada == "Todos" )
                        {
                            rellenaTabla(librosFichero, false);//nofunciona--no iba porq vaciaba la tabla
                        }
                        List<Libro> categoryList = __controlInit.findByCategory(librosFichero, __categoriaPulsada);
                        //tablaLibros.Rows.Clear();//vacio tabla
                        rellenaTabla( categoryList, true );
                    }
                }

            }
            #endregion
            if ( !this.IsPostBack )
            {
                rellenaTabla( librosFichero, false );
            } 

           
            //Devuelve una lista de libros...con sus atributos cargados.
           
        }

        private void rellenaTabla( List<Libro> libros, bool porCategoria )
        {
            
            TableCell cell;
            TableRow row;
            int librosTotales = libros.Count;
            int librosRestantes = libros.Count % 3;
            int filas = librosTotales / 3;

            //tablaLibros.Style.Add(HtmlTextWriterStyle.TextAlign, "justify");

            if ( !porCategoria )
            {
                for (int i = 0; i < filas; i++)//quiero 4 libros por fila
                {
                    row = new TableRow();
                    tablaLibros.Rows.Add(row);
                    for (int j = 0; j < 3; j++)
                    {
                        cell = new TableCell();
                        cell.BorderColor = System.Drawing.Color.Black;
                        cell.Height=100;
                        cell.Width = 300;

                        cell.Style.Add("padding", "10px");
                        
                        //cell.ControlStyle.Width = Unit.Pixel(300);
                        //cell.Style.Add(HtmlTextWriterStyle., "200px");

                        Libro l = libros.ElementAt((i * 3) + j);

                        rellenaColumna(cell, l, row);
                    }

                }
                //una vez aqui, faltan libros. Cuantos? ---> librosRestantes
                if (librosRestantes != 0) //---> significa que quedan libros
                {
                    var inicio = librosTotales - librosRestantes;
                    var fin = librosTotales - 1; //posiciones del array
                    row = new TableRow();
                    tablaLibros.Rows.Add(row);

                    for (int k = inicio; k <= fin; k++)
                    {
                        cell = new TableCell();
                        cell.Style.Add("padding", "10px");
                        //cell.ControlStyle.Width = Unit.Pixel(300);

                        Libro l = libros.ElementAt(k);
                        rellenaColumna(cell, l, row);
                    }
                }
            }
            else if( porCategoria )
            {
               // tablaLibros.Rows.Clear();
                TableRow r = new TableRow();
                tablaLibros.Rows.Add( r );
                TableCell c;
                
                foreach ( Libro lib in libros )
                {
                    c = new TableCell();
                    c.Style.Add("padding", "10px");
                    //c.Style.Add("width", "200px");
                    
                    rellenaColumna(c, lib, r);
                }
            }
            //throw new NotImplementedException();
        }

        
        public void rellenaColumna( TableCell cell, Libro l, TableRow row ) {

            MiniControlLibro __micontrol = (MiniControlLibro)Page.LoadControl(("~/Controles_Personalizados/MiniControlLibro.ascx"));
            __micontrol.TituloControl = l.Titulo;
            __micontrol.EditorialControl = l.Editorial;
            __micontrol.AutorControl = l.Autor;
            __micontrol.PrecioControl = l.Precio;
            __micontrol.ISBNControl = l.ISBN10;

            cell.Controls.Add( __micontrol );

            //cell.Controls.Add(new Label { Text = "Titulo: " + l.Titulo + "\n" });
            //cell.Controls.Add(new Label { Text = "Autor: " + l.Autor + "\n" });
            //cell.Controls.Add(new Label { Text = "Editorial: " + l.Editorial + "\n" });
            //cell.Controls.Add(new Label { Text = "Categoria: " + l.Categoria + "\n" });
            //cell.Controls.Add(new Label { Text = "ISBN-10: " + l.ISBN10 + "\n" });
            //cell.Controls.Add(new Label { Text = "ISBN-13: " + l.ISBN13 + "\n" });
            //cell.Controls.Add(new Label { Text = "Precio: " + l.Precio + "\n" });
            //cell.Controls.Add(new Label { Text = "Paginas: " + l.NumPag + "\n" });
            //cell.Controls.Add(new Label { Text = "Resumen: " + l.Resumen + "\n" });
            //cell.Controls.Add(new Button { Text = "Al carro" });

            row.Cells.Add(cell);

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
