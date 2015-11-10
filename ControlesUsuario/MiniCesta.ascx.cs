using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agapea.ControlesUsuario
{
    public partial class MiniCesta : System.Web.UI.UserControl
    {
        private string __items;

        public string NumeroItems
        {
            get { return this.__items; }
            set { this.__items = value; this.labelItems.Text = this.__items + "items"; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}