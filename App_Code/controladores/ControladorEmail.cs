using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agapea.App_Code.controladores;
using Agapea.App_Code.modelos;
using System.Net;
using System.Net.Mail;
namespace Agapea.App_Code.controladores
{
    /*

        Todo esto casca.....hay q revisar clase Usuario
        y crear metodo getCesta o algo asi

    */
    public class ControladorEmail
    {
        //public bool MandarEmail(Usuario u)
        //{
        //    MailMessage mensaje = this.CrearEmail(u);
        //    SmtpClient server = new SmtpClient("smtp.gmail.com", 587);
        //    try
        //    {
        //        server.Send(mensaje);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
            
        //}
        //private MailMessage CrearEmail (Usuario user)
        //{
        //    Dictionary<string, Libro> librosCarrito = user.ObtenerCarrito();
        //    ControladorPDF generadorFactura = new ControladorPDF();

        //    MailMessage mail = new MailMessage();
        //    mail.To.Add(new MailAddress( user.Correo));
        //    mail.From = new MailAddress("agapeashop@outlook.com");
        //    mail.Subject = "factura agapea";
        //    mail.Attachments.Add(new Attachment(generadorFactura.GenerarFactura(librosCarrito)));
        //}
    }
}