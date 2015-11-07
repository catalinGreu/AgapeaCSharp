using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agapea.App_Code.modelos;
namespace Agapea.ControlesUsuario
{
    public partial class MiniDetallesLibro : System.Web.UI.UserControl
    {
        #region "---propiedades del control"
        private string __titulo;
        private string __autor;
        private string __editorial;
        private string __paginas;
        private string __resumen;
        private string __ISBN10;
        private string __ISBN13;
        private decimal __precio;
        #endregion

        #region "getters y setters"
        public string TituloControl
        {
            get { return this.__titulo; }
            set
            {
                this.__titulo = value;
                this.labelTitulo.Text = this.__titulo;
            }
        }

        public string AutorControl
        {
            get { return this.__autor; }
            set
            {
                this.__autor = value;
                this.labelAutor.Text = this.__autor;
            }
        }
        public string EditorialControl
        {
            get { return this.__editorial; }
            set
            {
                this.__editorial = value;
                this.labelED.Text = this.__editorial;
            }
        }
        public string PaginasControl
        {
            get { return this.__paginas; }
            set
            {
                this.__paginas = value;
                this.labelNumPag.Text = this.__paginas + " páginas";
            }
        }
        public string ResumenControl
        {
            get { return this.__resumen; }
            set
            {
                this.__resumen = value;
                this.labelResum.Text = this.__resumen;
            }
        }
        public string ISBN10Control
        {
            get { return this.__ISBN10; }
            set
            {
                this.__ISBN10 = value;
                this.labelISBN10.Text = this.__ISBN10;
            }
        }
        public string ISBN13Control
        {
            get { return this.__ISBN13; }
            set
            {
                this.__ISBN13 = value;
                this.labelISBN13.Text = this.__ISBN13;
            }
        }
        public decimal PrecioControl
        {
            get { return this.__precio; }
            set
            {
                this.__precio = value;
                this.labelPrecio.Text = this.__precio.ToString() + " €";
            }
        }
        #endregion


        //----constructor
        public MiniDetallesLibro() { }
        public MiniDetallesLibro (Libro l)
        {

            this.TituloControl = l.Titulo;
            this.AutorControl = l.Autor;
            this.EditorialControl = l.Editorial;
            this.PaginasControl = l.NumPag;
            this.ResumenControl = l.Resumen;
            this.ISBN10Control = l.ISBN10;
            this.ISBN13Control = l.ISBN13;
            this.PrecioControl = l.Precio;

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void linkVolver_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("MyInicio.aspx");
        }
    }
}