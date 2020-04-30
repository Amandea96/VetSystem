using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetSystemEngineer.ViewModels;
using MailKit.Net.Smtp;
using MimeKit;
using System.IO;
using MailKit.Security;

namespace VetSystemEngineer.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly SendingConfig _emailConfig;
        public static readonly Microsoft.AspNetCore.Html.HtmlString NewLine;
        public EmailSender(SendingConfig emailConfig)
        {
            _emailConfig = emailConfig;
        }

       

       

        public async Task SendEmailAsync(Message message)
        {
            var mailMessage = CreateEmailMessage(message);

            await SendAsync(mailMessage);
        }



        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_emailConfig.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;

            var bodyBuilder = new BodyBuilder { HtmlBody = string.Format("<h2>{0}</h2>", message.Content) };

          

            emailMessage.Body = bodyBuilder.ToMessageBody();
            return emailMessage;
        }

       

        private async Task SendAsync(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(_emailConfig.Smtp, _emailConfig.Port, SecureSocketOptions.StartTlsWhenAvailable);
                    
                    await client.AuthenticateAsync(_emailConfig.UserName, _emailConfig.Password);

                    await client.SendAsync(mailMessage);
                }
                catch
                {
                    
                    throw;
                }
                finally
                {
                    await client.DisconnectAsync(true);
                    client.Dispose();
                }
            }
        }
    }
}
