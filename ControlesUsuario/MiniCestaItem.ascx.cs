using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agapea.App_Code.modelos;
namespace Agapea.ControlesUsuario
{
    public partial class MiniCestaItem : System.Web.UI.UserControl
    {
        private string __titulo;
        private string __autor;
        private decimal __precio;
        private string __ISBN;

        #region "controles getters y setters"
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
        public decimal PrecioControl
        {
            get { return this.__precio; }
            set
            {
                this.__precio = value;
                this.labelPrecio.Text = this.__precio + " €";
            }
        }
        public string ISBNControl
        {
            get { return this.__ISBN; }
            set
            {
                this.__ISBN = value;
                this.labelISBN.Text = this.__ISBN;
            }
        }
        
        #endregion
       

        //---------constructores-------
        public MiniCestaItem() { }

        public MiniCestaItem(Libro l)
        {

            this.TituloControl = l.Titulo;
            this.AutorControl = l.Autor;
            this.PrecioControl = l.Precio;
            this.ISBNControl = l.ISBN10;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}