using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var mock = new SendEmailCommand();
                mock.Name = "Gabriel Victorino";
                mock.Number = 1234;
                mock.Email = "Email CC";
                mock.Data = DateTime.Now;
                mock.Termos = "Aceito os termos";

                var mailMessage = new MailMessage("Seu email", "Seu email");
                mailMessage.Subject = "Acceptance Term";
                mailMessage.IsBodyHtml = true;

                MailAddress copy = new MailAddress(mock.Email);
                mailMessage.CC.Add(copy);

                mailMessage.Body = $@"<p> Nome: {mock.Name} </p> 
                                      <p> Re: {mock.Number}</p>
                                      <p> Data de aceite: {mock.Data}</p>
                                      <p> Termo de aceite: {mock.Termos}</p>";


                mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("Seu email", mock.Senha);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);

                Console.WriteLine("Seu email foi enviado com sucesso");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Houve um erro no envio do email");
                Console.ReadLine();
            }
        }
    }
}
