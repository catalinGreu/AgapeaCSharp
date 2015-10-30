using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agapea.App_Code.modelos;
using Agapea.App_Code.controladores;
using Agapea.Controles_Personalizados;
namespace Agapea
{
    public partial class VistaDetallesLibro : System.Web.UI.Page
    {
        private Controlador_Vista_Inicio __controlInit;
        private List<Libro> listaRecuperada;
        private string __rutaControl = "~/Controles_Personalizados/MiniControlDetallesLibro.ascx";
        protected void Page_Load(object sender, EventArgs e)
        {
            __controlInit = new Controlador_Vista_Inicio();
            listaRecuperada = __controlInit.infoLibros("./Ficheros/libros.txt");

            string parametroISBN = this.Request.Params["isbn"];

            var resultado = from libro in listaRecuperada
                            where libro.ISBN10 == parametroISBN
                            select libro;

            Libro l = (Libro) resultado.Single();

            MiniControlDetallesLibro __controlDetallado = (MiniControlDetallesLibro)Page.LoadControl(( __rutaControl ));
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
            this.tablaDetallesLibro.Rows.Add(row);

            cell.Controls.Add(__controlDetallado);
            row.Cells.Add(cell);         



        }
    }
}