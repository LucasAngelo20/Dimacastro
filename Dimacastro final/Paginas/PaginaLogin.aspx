 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaLogin.aspx.cs" Inherits="Dimacastro_final.PaginaLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="email" id="txtEmail" placeholder="Email" runat="server" autocomplete="off"/><br />
            <input type="password" id="txtSenha" placeholder="Senha" runat="server" autocomplete="off"/><br />
            <asp:CheckBox text="Lembrar de mim" ID="cLembrar" runat="server"/><br />
            <a href="PaginaCadastro.aspx">Cadastrar</a>
            <a href="PaginaResetPassword.aspx" runat="server">Esqueci a senha</a><br /><br />
            <asp:Button Text="Entrar" onclick="LogIn" runat="server"/>
        </div>
    </form>
</body>
</html>
