using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

namespace Dimacastro_final
{
    public partial class PaginaPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            UserDMO user = new UserDMO();
            List<PedidoDMO> lsPedido = new List<PedidoDMO>();
            user.userToken = Request.Cookies["dimacastro"]["userToken"];
            user = UserDAO.userCookie(user);
            lsPedido = PedidoDAO.selectPedidos(user);

                user = UserDAO.Username(user);
                HtmlGenericControl nav = new HtmlGenericControl("h1");
                nav.InnerHtml = user.username;
                username.Controls.Add(nav);


                for (int i = 0; i < lsPedido.Count; i++)
                {
                    divTable.Attributes["class"] = "table-sortable-hidden-off"; 
                    HtmlGenericControl div = new HtmlGenericControl("tr");
                    div.InnerHtml =
                    "<td>" + lsPedido[i].id + "</td>" +
                    "<td>" + lsPedido[i].fkLoja + "</td>" +
                    "<td>" + lsPedido[i].valor + "</td>";

                    container.Controls.Add(div);
                }
            }

        protected void redirectPedidos(object sender, EventArgs e)
        {
            Response.Redirect("PaginaCadastrarPedido.aspx");
        }
        protected void LogOff(object sender, EventArgs e)
        {
            Response.Cookies["dimacastro"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("PaginaLogin.aspx");
        }
    }
}
