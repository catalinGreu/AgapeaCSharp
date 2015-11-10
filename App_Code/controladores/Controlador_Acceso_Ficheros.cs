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

        private StreamReader reader;
        private StreamWriter writer;
        private FileStream ficheroTexto;
        private string cadenaUsuario = "";

        public Boolean AbrirFichero(string ruta)
        {
            try
            {

                using (this.writer = File.AppendText(ruta))

                    // this.lectorFichero = new StreamReader(ruta, false);
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());//esto no va si no hay main
                return false;
            }

        }

        public Boolean GrabarDatosFichero(Usuario u, string ruta)
        {
            cadenaUsuario = (u.NombreUsuario + ":" + u.Password + ":" + u.Correo + ":" + u.Nombre + ":" + u.Apellidos);

            writer = new StreamWriter(ruta, true);
            writer.WriteLine(cadenaUsuario);
            writer.Close();


            return true;
        }
        public Boolean existeUsuario(string id, string pass, string ruta)
        {
            reader = new StreamReader(HttpContext.Current.Request.MapPath(ruta));

            bool resultado = (from linea in reader.ReadToEnd().Split(new char[] { '\r', '\n' }).Where(linea => !new System.Text.RegularExpressions.Regex("^$").Match(linea).Success)
                              let campousu = linea.Split(new char[] { ':' })[0]
                              let campopass = linea.Split(new char[] { ':' })[1]
                              where id == campousu && pass == campopass
                              select true).SingleOrDefault();
            return resultado;

        }


    }
}