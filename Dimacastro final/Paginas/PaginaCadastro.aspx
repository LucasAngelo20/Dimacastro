<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaCadastro.aspx.cs" Inherits="Dimacastro_final.PaginaCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <input  type="email" id="txtEmail" placeholder="Digite o seu email" runat="server" autocomplete="off"/><br />
        <input  type="password" id="txtSenha" placeholder="Digite a sua senha" runat="server" autocomplete="off"/><br />
        <input  type="text" id="txtUsername" placeholder="Digite o seu username" runat="server" autocomplete="off"/><br />
        <input  type="text" id="txtCnpj" placeholder="Digite o CNPJ" runat="server" autocomplete="off"/><br />
        <input  type="tel" id="txtTelefone" placeholder="Digite o seu telefone" runat="server" autocomplete="off"/><br />
            <select name="selectLoja" id="selectLoja" runat="server">
                <option value="1">Loja 1</option>
                <option value="2">Loja 2</option>
                <option value="3">Loja 3</option>
                </select><br /><br />
        <asp:Button Text="Enviar" OnClick="Cadastrar" ID="botao" runat="server" /> 
        </div>
    </form>
</body>
</html>
