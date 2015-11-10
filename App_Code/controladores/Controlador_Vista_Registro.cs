using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agapea.App_Code.modelos;

namespace Agapea.App_Code.controladores
{
    public class Controlador_Vista_Registro
    {
        private Controlador_Acceso_Ficheros micontrolador = new Controlador_Acceso_Ficheros();

        public Usuario GrabarDatosUsuario(string Usuario, string Apellidos, 
            string Correo, string Nombre, string pass)
        {

            Usuario u = new Usuario();

            u.NombreUsuario = Usuario;
            u.Correo = Correo;
            u.Password = pass;
            u.Nombre = Nombre;
            u.Apellidos = Apellidos;            

            try {
                //existe y lo abre, o no existe y lo crea, true
                if ( micontrolador.AbrirFichero( HttpContext.Current.Request.MapPath ("./Ficheros/datosUsuarios.txt") ) )
                    {
                    
                    micontrolador.GrabarDatosFichero( u, HttpContext.Current.Request.MapPath("./Ficheros/datosUsuarios.txt")); 
                }
            }
            catch (Exception e) {

                return null;
            }
           
            // si al llamar al controlador del fichero y grabar los datos, se graban bien devuelvo nuevoUsuario, si no devuelvo null
            return u;
        }
    }
}