using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agapea.App_Code.modelos;
using Agapea.ControlesUsuario;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace Agapea.App_Code.controladores
{
    public class ControladorTablas
    {
        private const string __rutaControlLibro = "~/ControlesUsuario/MiniLibro.ascx";
        private string __rutaControl = "~/ControlesUsuario/MiniDetallesLibro.ascx";
        private Page __laPagina;

        public ControladorTablas() { }
        public ControladorTablas(Page p)
        {
            this.__laPagina = p;
        }

        public void rellenaTablaLibros(Table tablaLibros, List<Libro> libros, bool porCategoria)
        {

            TableCell cell;
            TableRow row;
            int librosTotales = libros.Count;
            int librosRestantes = libros.Count % 3;
            int filas = librosTotales / 3;

            if (!porCategoria)
            {
                for (int i = 0; i < filas; i++)//quiero 4 libros por fila
                {
                    row = new TableRow();
                    tablaLibros.Rows.Add(row);
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
                    tablaLibros.Rows.Add(row);

                    for (int k = inicio; k <= fin; k++)
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
                tablaLibros.Rows.Add(r);
                TableCell c;

                foreach (Libro lib in libros)
                {
                    c = new TableCell();
                    c.Style.Add("padding", "10px");

                    rellenaColumna(c, lib, r);
                }
            }
        }

        private void rellenaColumna(TableCell cell, Libro l, TableRow row)
        {

            MiniLibro __micontrol = (MiniLibro)__laPagina.LoadControl((__rutaControlLibro));
            __micontrol.TituloControl = l.Titulo;
            __micontrol.EditorialControl = l.Editorial;
            __micontrol.AutorControl = l.Autor;
            __micontrol.PrecioControl = l.Precio;
            __micontrol.ISBNControl = l.ISBN10;

            ((LinkButton)__micontrol.FindControl("linkButtonTitulo")).ID += l.ISBN10;

            cell.Controls.Add(__micontrol);
            row.Cells.Add(cell);
        }

        public void rellenaControlDetallado( Table tabla, Libro l )
        {
            MiniDetallesLibro __controlDetallado = (MiniDetallesLibro)__laPagina.LoadControl((__rutaControl));

            __controlDetallado.TituloControl = l.Titulo;
            __controlDetallado.AutorControl = l.Autor;
            __controlDetallado.EditorialControl = l.Editorial;
            __controlDetallado.PaginasControl = l.NumPag;
            __controlDetallado.PrecioControl = l.Precio;
            __controlDetallado.ISBN10Control = l.ISBN10;
            __controlDetallado.ISBN13Control = l.ISBN13;
            __controlDetallado.ResumenControl = l.Resumen;

            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            tabla.Rows.Add(row);

            cell.Controls.Add(__controlDetallado);
            row.Cells.Add(cell);
        }
    }
}