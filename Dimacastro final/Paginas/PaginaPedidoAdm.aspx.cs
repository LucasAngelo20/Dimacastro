using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

namespace Dimacastro_final
{
    public partial class PaginaPedidoAdm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<PedidoDMO> lsPedido = new List<PedidoDMO>();
            lsPedido = PedidoDAO.selectPedidosAdm();

            for (int i = 0; i < lsPedido.Count; i++)
            {
                HtmlGenericControl div = new HtmlGenericControl("tr");
                div.InnerHtml =
                "<td>" + lsPedido[i].id + "</td>" +
                "<td>" + lsPedido[i].fkLoja + "</td>" +
                "<td>" + lsPedido[i].valor + "</td>" +
                "<td>" + lsPedido[i].fkUser + "</td>";

                container.Controls.Add(div);
            }
        }
        protected void LogOff(object sender, EventArgs e)
        {
            Response.Cookies["dimacastro"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("PaginaLogin.aspx");
        }
    }
}