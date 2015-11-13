//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Agapea.ControlesUsuario;
//using Agapea.App_Code.controladores;
//using Agapea.App_Code.modelos;
//using System.Text;
//using Spire.Pdf;
//using System.Threading.Tasks;
//namespace Agapea.App_Code.controladores
//{
//    public class ControladorPDF
//    {
//        public ControladorPDF(Cesta c, Usuario u) { }
//        public ControladorPDF()
//        { }

//        public PdfDocument crearPDF(string facturaEnHtml)
//        {
//            PdfDocument factura = new PdfDocument();
//            Task generadorPDF = new Task(() => factura.LoadFromHTML(facturaEnHtml, false, true, true));
//            generadorPDF.Start();

//            //si quiero guardar el pdf en el servidor: factura.SaveToFile("nombre_fichero.pdf");
//            generadorPDF.Wait(); // asi me aseguro de que si no ha acabado lo acabe. el Hilo
//            return factura;

//        }
//        public String GenerarFactura (Dictionary<string,Libro> ColleccionLibrosCarrito )
//        {
//            StringBuilder midocHTML = new StringBuilder();
//            midocHTML.Append("<html> <head> <title>....Factura carrito.....</title> </head> <html>");
//            midocHTML.Append("<body><image src='" + HttpContext.Current.Request.MapPath("imagenes/cabecera.png") + "/>");
//            midocHTML.Append("<table>");
//            midocHTML.Append("<tr>") + (from unlibro in ColleccionLibrosCarrito
//                                        select "<tr><td>" + unlibro.Titulo + "</td>" +
//                                                "<td>" + unlibro.Autor + "</td></tr>").Single()

//                                         );
//            midocHTML.Append("</table></body></html>");
//            return midocHTML.ToString();

//        }

//    }
//}