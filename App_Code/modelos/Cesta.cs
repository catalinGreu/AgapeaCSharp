using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agapea.App_Code.modelos;
using System.Collections.Specialized;
namespace Agapea.App_Code.modelos
{
    
    public class Cesta
    {        
        private List<Libro> __acumulados;
        private NameValueCollection __misCookies;
        private string __iduser;

        public Cesta() { this.__acumulados = new List<Libro>(); }
        public Cesta( Usuario u ) {

            this.__iduser = u.NombreUsuario;
            this.__acumulados = new List<Libro>();
        }

        public void addLibro( Libro l ) { this.__acumulados.Add( l ); }
        public void quitaLibro( Libro l) { this.__acumulados.Remove( l ); }
        public List<Libro> getLibros() { return this.__acumulados; }

        public void removeAll(List<Libro> lista)
        {
            foreach ( Libro l in lista )
            {
                lista.Remove(l);
            }
        }


        public NameValueCollection getCookies( HttpRequest r, string idCookie )
        {
            ///esto debería comprobar las cookies
            try
            {
                if ( r.Cookies[idCookie] != null )
                {
                    __misCookies = r.Cookies[idCookie].Values;
                }

                return this.__misCookies;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}

    