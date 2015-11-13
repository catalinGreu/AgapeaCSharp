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

        private StreamReader fichero;
        private StreamWriter writer;
        private string cadenaUsuario = "";
        private Libro l;
        private List<Libro> lista;

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

        public List<Libro> librosByISBN(string[] isbns, string ruta)
        {
            fichero = new StreamReader(HttpContext.Current.Request.MapPath(ruta));
            //List<Libro> listaRetorno = new List<Libro>();
            //string[] lineasDevueltas = new string[] { };

            return (from unalinea in fichero.ReadToEnd().Split(new char[] { '\r', '\n' }).Where(linea => !new System.Text.RegularExpressions.Regex("^$").Match(linea).Success)
                    let campoISBN10 = unalinea.Split(new char[] { ':' })[4]
                    let elementos = unalinea.Split(new char[] { ':' })
                    join isbn in isbns
                    on campoISBN10 equals isbn
                    select new Libro()
                    {
                        Titulo = elementos[0],
                        Autor = elementos[1],
                        Editorial = elementos[2],
                        Categoria = elementos[3],
                        ISBN10 = elementos[4],
                        ISBN13 = elementos[5],
                        Precio = Convert.ToDecimal(elementos[6]),
                        NumPag = elementos[7],
                        Resumen = elementos[8]
                    }).ToList<Libro>();
            
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
            fichero = new StreamReader(HttpContext.Current.Request.MapPath(ruta));

            bool resultado = (from linea in fichero.ReadToEnd().Split(new char[] { '\r', '\n' }).Where(linea => !new System.Text.RegularExpressions.Regex("^$").Match(linea).Success)
                              let campousu = linea.Split(new char[] { ':' })[0]
                              let campopass = linea.Split(new char[] { ':' })[1]
                              where id == campousu && pass == campopass
                              select true).SingleOrDefault();
            return resultado;

        }

        public List<Libro> infoLibros(string ruta)
        {
            //int cont = 0;
            string linea;
            fichero = new StreamReader(HttpContext.Current.Request.MapPath(ruta));
            lista = new List<Libro>();

            while ((linea = fichero.ReadLine()) != null)
            {

                string[] elementos = linea.Split(new char[] { ':' });

                l = new Libro();

                l.Titulo = elementos[0];
                l.Autor = elementos[1];
                l.Editorial = elementos[2];
                l.Categoria = elementos[3];
                l.ISBN10 = elementos[4];
                l.ISBN13 = elementos[5];
                //l.Precio = decimal.Parse(elementos[6]);//esto la ultima vez no iba.
                l.Precio = Convert.ToDecimal(elementos[6]);
                l.NumPag = elementos[7];
                l.Resumen = elementos[8];

                lista.Add(l);

            }

            fichero.Close();

            return lista;

        }

        public List<Libro> findByCategory(List<Libro> lista, string categoria)
        {

            int comprobacion = lista.Count;

            List<Libro> listaRet = new List<Libro>();

            var resultado = from libro in lista
                            where libro.Categoria == categoria
                            select libro;


            //var resultado = (from linea in new StreamReader(HttpContext.Current.Request.MapPath(ruta)).ReadToEnd().Split(new char[] { '\r','\n'}).Where(linea2 => ! new Regex("^$").Match(linea2).Success)
            //                 let match = linea.Split(new char[] { ':' })[3]
            //                 where match == categoria
            //                 select linea );

            //suponiendo que me devuelve una coleccion de strings....
            foreach (Libro l in resultado)
            {
                listaRet.Add(l);

            }
            return listaRet;
        }
    }
}