<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaResetPassword.aspx.cs" Inherits="Dimacastro_final.Paginas.PaginaResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">Digite o seu email de recuperação</asp:Label>
            <input type="email" autocomplete="off" id="txtEmail" runat="server" placeholder="Digite o seu email"/>
            <asp:Button id="btnPassword" Text="Enviar" OnClick="PasswordResetSend" runat="server"/>
        </div>
    </form>
</body>
</html>
