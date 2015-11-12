using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agapea
{
    public partial class VistaCesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TableRow row;
            TableCell cell;
            for (int i = 0; i < 6; i++)
            {
                row = new TableRow();
                
                this.tablaItems.Controls.Add(row);
                for (int j = 0; j < 4; j++)
                {
                    cell = new TableCell();
                    cell.Text = "Cookie: " + j + " "+Request.Cookies["cesta"]["libros"];
                    row.Controls.Add(cell);
                }
            }
            /*
            Leo la cookie y obtengo todos los ISBN
            Paso un array de strings con los ISBN's a un metodo
            que me crea y devuelve una lista de libros con esos ISBN
            leyendolos del fichero.
            voy rellenando la tablaItems con MiniCestaItem
            */
        }
    }
}