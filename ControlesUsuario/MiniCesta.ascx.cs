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
        private int __items = 0;
        private int __total = 0;

        public int addItem()
        {
            this.__items += 1;
            this.labelItems.Text = this.__items.ToString();
            this.__total++;
            return this.__items;

        }

        public int TotalItems
        {
            get { return this.__total; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}