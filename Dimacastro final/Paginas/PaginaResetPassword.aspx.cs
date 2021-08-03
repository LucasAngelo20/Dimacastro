
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Web;

namespace Dimacastro_final.Paginas
{
    public partial class PaginaResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PasswordResetSend(object sender, EventArgs e)
        {
                UserDMO user = new UserDMO();
                user.emailRecovery = txtEmail.Value;
                user = UserDAO.emailRecoveryVerify(user);
                string Token = UserDAO.Token();
                user.userTokenR = Token;

                if (user.email != null)
                {
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    
                    MailMessage mail = new MailMessage("EmailTesteDimacastro@gmail.com", user.emailRecovery);
                    mail.Subject = "Sua Senha em Dimacastro";
                    mail.Body = string.Format("Olá!: <h1>{0}</h1><br/> A sua senha é: https://localhost:44385/Paginas/PaginaResetPasswordSenha.aspx?Token=" + Token , user.username );
                    mail.IsBodyHtml = true;

                    NetworkCredential nc = new NetworkCredential();
                    nc.UserName = "EmailTesteDimacastro@gmail.com";
                    nc.Password = "EmailTeste1234";

                    string port = "587";
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = nc;
                    smtp.Port = Convert.ToInt32(port);
                    smtp.Send(mail);

                    user = UserDAO.insertToken(user);

            }
            else
            {
                Response.Redirect("PaginaLogin.aspx");
            }
        }
    }
}