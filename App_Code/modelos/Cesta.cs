using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agapea.App_Code.modelos;
namespace Agapea.App_Code.modelos
{
    
    public class Cesta
    {        
        private List<Libro> __acumulados;
    


        public Cesta() {

            this.__acumulados = new List<Libro>();
        }

        public void addLibro( Libro l ) { this.__acumulados.Add( l ); }
        public void quitaLibro( Libro l) { this.__acumulados.Remove( l ); }
        public List<Libro> getLibros() { return this.__acumulados; }
    }

}

    