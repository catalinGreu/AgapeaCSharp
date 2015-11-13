using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agapea.App_Code.controladores;
namespace Agapea
{
    public partial class VistaLogin : System.Web.UI.Page
    {
        Controlador_Acceso_Ficheros __control;
        string ruta = "./Ficheros/datosUsuarios.txt";
        protected void Page_Load(object sender, EventArgs e)
        {
            this.inputID.Focus();

        }

        protected void botonEntrar_Click(object sender, EventArgs e)
        {
            if (!this.IsValid)
            {
                return;
            }
            else if (this.IsValid)
            {
                __control = new Controlador_Acceso_Ficheros();

                if (__control.existeUsuario(this.inputID.Text, this.inputPass.Text, ruta))
                {
                    this.Session["Usuario"] = this.inputID.Text;
                    this.Response.Redirect("MyInicio.aspx");
                }
                else
                {
                    this.labelError.Text = "Usuario o Password incorrectas";
                }
            }
        }

        protected void btonRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}