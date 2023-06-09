﻿using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoViewModel contacto);
    }

    public class ServicioEmailSendGrid : IServicioEmail
    {
        private readonly IConfiguration configuration;

        public ServicioEmailSendGrid(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Enviar(ContactoViewModel contacto)
        {
            var apikey = configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = configuration.GetValue<string>("SENDGRID_NOMBRE");

            var cliente = new SendGridClient(apikey);
            var from = new EmailAddress(email, nombre);
            var subject = $"El cliente {contacto.Email} quiere  contactarte";
            var to = new EmailAddress(email, nombre);
            var mensajeTextoPlano = contacto.Mensaje;
            var ContenidoHtml = @$"De: {contacto.Nombre} - 
                                Email: {contacto.Email}
                                mensaje: {contacto.Mensaje}";
            var singleEmail = MailHelper.CreateSingleEmail (from, to, subject, mensajeTextoPlano, ContenidoHtml);
            var respuesta = await cliente.SendEmailAsync(singleEmail);
        }
    }
}
