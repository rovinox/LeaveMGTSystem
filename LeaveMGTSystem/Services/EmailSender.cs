// using System;
// using System.Collections.Generic;
// using System.Linq;

// using System.Threading.Tasks;
// using MailKit.Net.Smtp;
// using MailKit.Security;
// using MimeKit;
// using MimeKit.Text;

// namespace LeaveMGTSystem.Services
// {
//     public class EmailSender(IConfiguration _config) : IEmailSender
//     {
//         public  SendEmailAsync(string email, string subject, string htmlMessage)
//         {
//              var fromAddress = _configuration["EmailSettings:DefaultEmailAddress"];
//             var smtpServer = _configuration["EmailSettings:Server"];
//             var smtpPort = Convert.ToInt32(_configuration["EmailSettings:Port"]);
//             var message = new MailMessage
//             {
//                 From = new MailAddress(fromAddress),
//                 Subject = subject,
//                 Body = htmlMessage,
//                 IsBodyHtml = true
//             };

//             message.To.Add(new MailAddress(email));

//             using var client = new SmtpClient(smtpServer, smtpPort);
//             await client.SendMailAsync(message);
//        }

//         public Task SendEmail(string email, string subject, string htmlMessage)
//         {
//             var emailDTO = new MimeMessage();
//             emailDTO.From.Add(MailboxAddress.Parse(_config.GetSection("EmailSettings:EmailUsername").Value));
//             emailDTO.To.Add(MailboxAddress.Parse(email));
//             emailDTO.Subject = subject;
//             emailDTO.Body = new TextPart(TextFormat.Html) { Text = htmlMessage };

//             using var smtp = new SmtpClient();
//             smtp.Connect(_config.GetSection("EmailSettings:EmailHost").Value, 587, SecureSocketOptions.StartTls);
//             smtp.Authenticate(_config.GetSection("EmailSettings:EmailUsername").Value, _config.GetSection("EmailSettings:EmailPassword").Value);
//             smtp.Send(emailDTO);
//             smtp.Disconnect(true);
//         }
//     }
// }