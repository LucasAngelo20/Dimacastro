using System;

namespace Dimacastro_final
{
    public partial class PaginaCadastroPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void novoPedido(object sender, EventArgs e)
        {
            PedidoDMO pedido = new PedidoDMO();
            pedido.fkUser = Request.Cookies["dimacastro"]["userid"];
            pedido.valor = txtPedido.Value;
            pedido.fkLoja = selectLoja.Value;

            if (PedidoDAO.insertPedido(pedido))
            {
                Response.Redirect("PaginaPedidos.aspx");
            }
            else
            {
                Response.Redirect("PaginaErro.aspx");
            }
        }
    }
}