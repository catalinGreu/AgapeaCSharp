using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Agapea.App_Code.modelos;
namespace Agapea.App_Code.controladores
{
    public class Controlador_Acceso_Ficheros
    {

        private StreamReader lectorFichero;
        private StreamWriter escritorFichero;
        private FileStream ficheroTexto;
        private string cadenaUsuario = "";

        public Boolean AbrirFichero( string ruta )
        {
            try
            {
               
                using ( this.escritorFichero = File.AppendText( ruta ) )

                    // this.lectorFichero = new StreamReader(ruta, false);
                return true;
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.ToString());//esto no va si no hay main
                return false;
            }

        }

        public Boolean GrabarDatos ( Usuario u, string ruta )
        {
            cadenaUsuario = ("idUser: " + u.NombreUsuario + ", Correo: " + u.Correo + ", Contraseña: "
                + u.Password + ", Nombre: " + u.Nombre + ", Apellidos: " + u.Apellidos);

            escritorFichero = new StreamWriter( ruta, true );
            escritorFichero.WriteLine(cadenaUsuario + "\n");
            escritorFichero.Close();
            

            return true;
        }

        
    }
}