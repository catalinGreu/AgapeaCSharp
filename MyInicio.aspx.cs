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
    public partial class MyInicio : System.Web.UI.Page
    {
        private Controlador_Vista_Inicio __controlInit;
        private string __categoriaPulsada;
        private List<Libro> librosFichero;
        private const string __rutaControl = "~/Controles_Personalizados/MiniControlLibro.ascx";
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageButton ButtonCompra = (ImageButton) this.Master.FindControl("ButtonCompra");
            Label LabelUser = (Label) this.Master.FindControl("LabelUser");
            TreeView myTreeView = (TreeView) this.Master.FindControl("myTreeView");
           
            __controlInit = new Controlador_Vista_Inicio();

            librosFichero = __controlInit.infoLibros("./Ficheros/libros.txt");
            
            #region "sesionUser"
            if (this.Session["Usuario"] != null)
            {
                LabelUser.Text = (string) Session["Usuario"];
            }
            else
            {
                LabelUser.Text = "Parece que el nombre no se almacena bien";
            }

            ///---llamada a procedimiento interno para ver variables post

            #endregion

            mostrar();
            #region "isPostback"

            if ( this.IsPostBack )
            {//si quiero comprobar que botones se pulsan siempre necesitare un isPostBack.

                foreach (string clave in this.Request.Params.AllKeys)
                {

                    switch ( clave )
                    {
                        default:
                            break;
                    }
                    if (clave == ButtonCompra.ID)
                    {
                        LabelUser.Text = "HAS PULSADO EL BOTON!!";
                    }
                    else if ( clave == "__EVENTTARGET" && this.Request.Params[clave].Contains(myTreeView.ID ))
                    {
                        //si seleccion algo del treeView asigno la categoría a la variable
                        this.__categoriaPulsada = this.Request.Params["__EVENTARGUMENT"].ToString().Split((new char[] { '\\' }))[0].Substring(1);
                        LabelUser.Text = "has seleccionado el nodo treeview: " + __categoriaPulsada;
                        //metodo que devuelve libros con categorías....

                        if (__categoriaPulsada == "Todos")
                        {
                            rellenaTabla(librosFichero, false);//nofunciona--no iba porq vaciaba la tabla
                        }
                        List<Libro> categoryList = __controlInit.findByCategory(librosFichero, __categoriaPulsada);
                        rellenaTabla(categoryList, true);
                    }
                }

            }
            #endregion
            if (!this.IsPostBack)
            {
                cargaTree(myTreeView, librosFichero);
                rellenaTabla(librosFichero, false);
            }


            //Devuelve una lista de libros...con sus atributos cargados.

        }

        private void rellenaTabla(List<Libro> libros, bool porCategoria)
        {

            TableCell cell;
            TableRow row;
            int librosTotales = libros.Count;
            int librosRestantes = libros.Count % 3;
            int filas = librosTotales / 3;

            //tablaLibros.Style.Add(HtmlTextWriterStyle.TextAlign, "justify");

            if (!porCategoria)
            {
                for (int i = 0; i < filas; i++)//quiero 4 libros por fila
                {
                    row = new TableRow();
                    this.tablaLibros.Rows.Add(row);
                    for (int j = 0; j < 3; j++)
                    {
                        cell = new TableCell();
                        cell.BorderColor = System.Drawing.Color.Black;
                        cell.Height = 100;
                        cell.Width = 300;

                        cell.Style.Add("padding-top", "10px");

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
                    this.tablaLibros.Rows.Add(row);

                    for ( int k = inicio; k <= fin; k++ )
                    {
                        cell = new TableCell();
                        cell.Style.Add("padding-top", "10px");

                        Libro l = libros.ElementAt(k);
                        rellenaColumna(cell, l, row);
                    }
                }
            }
            else if (porCategoria)
            {
                TableRow r = new TableRow();
                this.tablaLibros.Rows.Add(r);
                TableCell c;

                foreach (Libro lib in libros)
                {
                    c = new TableCell();
                    c.Style.Add("padding", "10px");

                    rellenaColumna(c, lib, r);
                }
            }
        }


        public void rellenaColumna(TableCell cell, Libro l, TableRow row)
        {

            MiniControlLibro __micontrol = (MiniControlLibro)Page.LoadControl((__rutaControl));
            __micontrol.TituloControl = l.Titulo;
            __micontrol.EditorialControl = l.Editorial;
            __micontrol.AutorControl = l.Autor;
            __micontrol.PrecioControl = l.Precio;
            __micontrol.ISBNControl = l.ISBN10;

            cell.Controls.Add(__micontrol);

            row.Cells.Add(cell);

        }

        public void cargaTree( TreeView t, List<Libro> lista )
        {

            //Func< List<Libro>, List<string > MiFiltro = delegate (List<Libro> unelemento){
            //    List<string> __categorias = new List<string>();
            //    foreach(Libro unlibro in unelemento)
            //    {
            //        __categorias.Add(unlibro.Categoria);
            //    }
            //    return __categorias;
                     //                                                               };

            // var encontrados = lista.Select;
            //List<string> categorias = (from unlibro in lista
            //                           select unlibro.Categoria).Distinct().ToList();

            List<string> categorias2 = lista.Select(unlibro => unlibro.Categoria).Distinct().ToList();

            foreach (string categoria in categorias2)
            {
                t.Nodes.Add(new TreeNode( categoria, categoria ));
            }
            t.Nodes.Add(new TreeNode("Todos", "Todos"));
            
            
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
