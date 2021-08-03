<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaCadastrarPedido.aspx.cs" Inherits="Dimacastro_final.PaginaCadastroPedido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" id="txtPedido" placeholder="Insira o valor" runat="server"/>
            <select name="selectLoja" id="selectLoja" runat="server">
                <option value="1">Loja 1</option>
                <option value="2">Loja 2</option>
                <option value="3">Loja 3</option>
            </select>
            <asp:Button ID="btnCadastrar" onclick="novoPedido" Text="Cadastrar pedido" runat="server" />
        </div>
    </form>
</body>
</html>
