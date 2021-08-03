<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaResetPasswordSenha.aspx.cs" Inherits="Dimacastro_final.Paginas.PaginaResetPassowordSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="password" placeholder="Digite a sua senha" id="txtSenhaRecovery" runat="server" /><br />
            <input type="password" placeholder="Confirmação da senha" id="txtSenhaConfirm" runat="server" />

            <asp:Button OnClick="insertSenha" id="PassRBtn" text="Enviar" runat="server" />

        </div>
    </form>
</body>
</html>
