using System;
using System.Web;

namespace Dimacastro_final
{
    public partial class PaginaLogin : System.Web.UI.Page
    {
        private HttpCookie ReadCookie()
        {
            try
            {
                return this.Page.Request.Cookies["dimacastro"];
            }

            catch
            {
                return null;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = ReadCookie();
            if (cookie != null)
            {
                UserDMO user = new UserDMO();
                user.userToken = Request.Cookies["dimacastro"]["userToken"];
                user = UserDAO.userCookie(user);
                if (user.email != "0")
                {
                    if (user.UserAdmin == "0")
                    {
                        Response.Redirect("../Paginas/PaginaPedidos.aspx");
                    }
                    else if(user.UserAdmin == "1")
                    {
                        Response.Redirect("../Paginas/PaginaPedidoAdm.aspx");
                    }
                    else
                    {
                        Response.Cookies["dimacastro"].Expires = DateTime.Now.AddDays(-1);
                        Response.Redirect("PaginaLogin.aspx");
                    }
                }
            }  
        }

        protected void LogIn(object sender, EventArgs e)
        {

            HttpCookie cookie = new HttpCookie("dimacastro");
            UserDMO user = new UserDMO();
            string token = UserDAO.Token();
            user.userToken = token;
            user.email = txtEmail.Value;
            user.senha = txtSenha.Value;
            user = UserDAO.login(user);

            if (user.id != null)
            {
                if (cLembrar.Checked)
                {
                    
                    cookie["userToken"] = token;
                    cookie.Expires = DateTime.Now.AddDays(180d);
                    cookie.HttpOnly = true;
                    Response.Cookies.Add(cookie);
                    if (user.UserAdmin != "0")
                    {
                        Response.Redirect("PaginaPedidoAdm.aspx");
                    }
                    else
                    {
                        Response.Redirect("PaginaPedidos.aspx");
                    }
                }
                else
                {
                    cookie["userToken"] = user.userToken;
                    cookie.Expires = DateTime.Now.AddDays(1d);
                    cookie.HttpOnly = true;
                    Response.Cookies.Add(cookie);
                    if (user.UserAdmin != "0")
                    {
                        Response.Redirect("PaginaPedidoAdm.aspx");
                    }
                    else
                    {
                        Response.Redirect("PaginaPedidos.aspx");
                    }

                }
            }


        }
    }
}