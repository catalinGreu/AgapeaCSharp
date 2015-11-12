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
    public partial class Login : System.Web.UI.Page
    {
        Controlador_Acceso_Ficheros __control;
        string ruta = "./Ficheros/datosUsuarios.txt";
        protected void Page_Load(object sender, EventArgs e)
        {
            this.inputLogin.Focus();
           
        }

        protected void botonEntrar_Click(object sender, ImageClickEventArgs e)
        {
            if (!this.IsValid)
            {
                return;
            }
            else if (this.IsValid)
            {
                __control = new Controlador_Acceso_Ficheros();

                if ( __control.existeUsuario( this.inputLogin.Text, this.inputPass.Text, ruta) )
                {
                    this.Session["Usuario"] = this.inputLogin.Text;
                    this.Response.Redirect("MyInicio.aspx");
                }
                else
                {
                    this.labelError.Text = "Usuario o Password incorrectas";
                }
            }
        }

        protected void botonRegistro_Click( object sender, ImageClickEventArgs e )
        {
            this.Response.Redirect("Registro.aspx");
        }
    }
}