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
    public partial class Registro : System.Web.UI.Page
    {
        private Controlador_Vista_Registro __micontrolador;
        protected void Page_Load(object sender, EventArgs e)
        {
            inputUsuario.Focus();

        }

        protected void registerButton_Click(object sender, ImageClickEventArgs e)
        {
            if (!this.IsValid)
            {

                return;                
            }

            else {

                this.__micontrolador = new Controlador_Vista_Registro();

                this.__micontrolador.GrabarDatosUsuario(inputUsuario.Text, inputApellidos.Text, inputCorreo.Text, inputNombre.Text, inputPasswd.Text);

                try
                {
                    Response.Redirect("Inicio.aspx");
                }
                catch (Exception)
                {
                    throw;
                }          
            }

        }
    }
}