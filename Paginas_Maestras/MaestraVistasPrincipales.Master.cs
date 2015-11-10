using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agapea.App_Code.modelos;
using Agapea.App_Code.controladores;
using Agapea.ControlesUsuario;

namespace Agapea.Paginas_Maestras
{
    public partial class MaestraVistasPrincipales : System.Web.UI.MasterPage
    {
        private Controlador_Vista_Inicio __controlInit;
        private List<Libro> librosFichero;
       
        private string __categoriaPulsada;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            __controlInit = new Controlador_Vista_Inicio();
            librosFichero = __controlInit.infoLibros("./Ficheros/libros.txt");

            
            if ( !this.IsPostBack )
            {
                cargaTree( this.myTreeView, librosFichero );

            }
            else if ( this.IsPostBack )
            {
               
                /*
                si he pulsado comprar un libro...
                    - Boton mapeado contra un libro (ISBN)
                    - Creo nueva cesta
                    - Añado ese libro a la cesta
                    - Modifico el controlador MIniCesta y le sumo 1.
                    - Además....creo una cookie cesta,
                    y por cada libro concateno al valor el isbn.
                    En la vista Cesta...leo esa cookie para cargar los controles
                    de usuario con lnos datos de ese libro de la Cookie
                */
            }


        }
        public void cargaTree(TreeView t, List<Libro> lista)
        {
            List<string> categorias2 = lista.Select(unlibro => unlibro.Categoria).Distinct().ToList();

            foreach (string cat in categorias2)
            {
                t.Nodes.Add(new TreeNode(cat, cat));
            }
            t.Nodes.Add(new TreeNode("Todos", "Todos"));


        }
       
    }
}