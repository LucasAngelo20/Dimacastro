using System;
using System.Web;

namespace Dimacastro_final.Paginas
{
    public partial class PaginaResetPassowordSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string Token = Request.QueryString["Token"];

            if (Token != null)
            {
                UserDMO user = new UserDMO();
                user.userTokenR = Token;
                user = UserDAO.userCookiePasswordReset(user);
                if (user.id != "0")
                {
                   
                }
                else
                {
                    Response.Redirect("~/Paginas/PaginaErro.aspx");
                }
            }
        }

        protected void insertSenha(object sender, EventArgs e)
        {
            UserDMO user = new UserDMO();
            string Token = Request.QueryString["Token"];
            user.userTokenR =  Token;


            if (user.id != "0")
            {
                user.senhaReset = txtSenhaRecovery.Value;
                user = UserDAO.passReset(user);
            }
            else
            {
                Response.Redirect("~/Paginas/PaginaErro.aspx");
            }

            Response.Redirect("~/Paginas/PaginaLogin.aspx");
        }
    }

}