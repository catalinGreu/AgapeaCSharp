using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agapea.App_Code.controladores;
using Agapea.App_Code.modelos;
using System.IO;
using System.Text.RegularExpressions;

namespace Agapea.App_Code.controladores
{

    public class Controlador_Vista_Inicio
    {
        private StreamReader fichero;
        private Libro l;
        private List<Libro> lista;

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
                l.Precio = Convert.ToDecimal( elementos[6] );
                l.NumPag = elementos[7];
                l.Resumen = elementos[8];

                lista.Add(l);

            }

            fichero.Close();

            return lista;

        }

        public List<Libro> findByCategory(List<Libro> lista, string categoria) {

            int comprobacion = lista.Count;
     
            List<Libro> listaRet = new List<Libro>();

            var resultado =  from libro in lista                            
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