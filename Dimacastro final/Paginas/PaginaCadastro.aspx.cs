using System;
using System.Web;

namespace Dimacastro_final
{
    public partial class PaginaCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Cadastrar(object sender, EventArgs e)
        {
            UserDMO user = new UserDMO();
            string token = UserDAO.Token();
            user.email = txtEmail.Value;
            user.senha = txtSenha.Value;
            user.username = txtUsername.Value;
            user.CNPJ = txtCnpj.Value;
            user.telefone = txtTelefone.Value;
            user.fkLoja = selectLoja.Value;
            user = UserDAO.cadastrar(user);

            if (user.id != null)
            {
                HttpCookie cookie = new HttpCookie("dimacastro");
                cookie["userToken"] = token;   
                cookie.Expires = DateTime.Now.AddDays(7d);
                Response.Cookies.Add(cookie);
                Response.Redirect("PaginaPedidos.aspx");
            }

        }
    }
}