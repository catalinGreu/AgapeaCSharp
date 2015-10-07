using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agapea.App_Code.controladores;
using Agapea.App_Code.modelos;
using System.IO;
namespace Agapea.App_Code.controladores
{

    public class Controlador_Vista_Inicio
    {
        private StreamReader fichero;
        private Libro l;
        private List<Libro> lista;

        public string[] infoLibros(string ruta)
        {
            //int cont = 0;
            string linea;
            string retorno[];
            fichero = new StreamReader( HttpContext.Current.Request.MapPath( ruta ) );

            while ( ( linea = fichero.ReadLine()) != null ) 
            {
                //lista = new List<Libro>();
               string [] elementos = linea.Split ( new char[] { '\n' } );

                //Console.WriteLine(elementos.Length);
                //l = new Libro();

                //l.Titulo = elementos[0];
                //l.Autor = elementos[1];
                //l.Editorial = elementos[2];
                //l.Categoria = elementos[3];
                //l.ISBN10 = elementos[4];
                //l.ISBN13 = elementos[5];
                //l.Precio =  elementos[6];
                //l.NumPag = elementos[7];
                //l.Resumen = elementos[8];

                //lista.Add(l);
                
            }

            fichero.Close();

            return elementos;           
            
        }
    }
}