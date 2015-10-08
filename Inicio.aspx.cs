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
            this.LabelUser.Text = (string)this.Request.QueryString["Usuario"];
            ///---llamada a procedimiento interno para ver variables post

            mostrar();
            if (this.IsPostBack)
            {

                foreach (string clave in this.Request.Params.AllKeys)
                {
                    if (clave == this.ButtonCompra.ID)
                    {
                        this.LabelUser.Text = "HAS PULSADO EL BOTON!!";
                    }
                    //else if (clave == "_EVENTTARGET" && this.Request.Params[clave] == this.TreeView.id)
                    //{
                    //    this.LabelUser.Text = "has seleccionado el nodo treeview: " + this.Request.Params["_EVENTARGUMENT"].ToString();
                    //}
                }

            }

            __controlInit = new Controlador_Vista_Inicio();

            List<Libro> librosFichero = new List<Libro>();
            librosFichero = __controlInit.infoLibros("./Ficheros/libros.txt");
            //Devuelve una lista de libros...con sus atributos cargados.
            TableCell cell;
            TableRow row;
            int librosTotales = librosFichero.Count;
            double filasNecesarias = librosFichero.Count / 3;
            int filas = (int)Math.Ceiling(filasNecesarias);

            for (int i = 0; i < filas; i++)//quiero 3 libros por fila
            {
                row = new TableRow();
                tablaLibros.Rows.Add(row);

                for (int j = 0; j < 3; j++)
                {
                    cell = new TableCell();
                    cell.ControlStyle.BorderColor = System.Drawing.Color.Black;
                    cell.Style.Add("padding", "10px");

                    Libro l = librosFichero.ElementAt((i * 3) + j);

                    rellenaColumna(cell, l, row);                   

                    librosTotales--;
                    if ( librosTotales == 1 )
                    {
                        row = new TableRow();
                        tablaLibros.Rows.Add(row);
                        cell = new TableCell();
                        Libro lib = librosFichero.ElementAt(librosFichero.Count-1);
                        rellenaColumna(cell, lib, row);
                    }

                }

            }
        }
            public void rellenaColumna(TableCell cell, Libro l, TableRow row) {

            cell.Controls.Add(new Label { Text = "Titulo: " + l.Titulo + "\n" });
            cell.Controls.Add(new Label { Text = "Autor: " + l.Autor + "\n" });
            cell.Controls.Add(new Label { Text = "Editorial: " + l.Editorial + "\n" });
            cell.Controls.Add(new Label { Text = "Categoria: " + l.Categoria + "\n" });
            cell.Controls.Add(new Label { Text = "ISBN-10: " + l.ISBN10 + "\n" });
            cell.Controls.Add(new Label { Text = "ISBN-13: " + l.ISBN13 + "\n" });
            cell.Controls.Add(new Label { Text = "Precio: " + l.Precio + "\n" });
            cell.Controls.Add(new Label { Text = "Paginas: " + l.NumPag + "\n" });
            cell.Controls.Add(new Label { Text = "Resumen: " + l.Resumen + "\n" });

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
