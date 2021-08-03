<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPedidos.aspx.cs" Inherits="Dimacastro_final.PaginaPedidos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <title>Pedidos</title>
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <meta charset="utf-8" />
  <link rel="stylesheet" href="../Styles/StylePedidos.css"/>
</head>

<body>
  <nav>
    <div class="username" id="username" runat="server">
      <img src="../img/Perfil.jfif"/> 
    </div>
    
    <ul class="nav-links">
      <li>
        <a href="#">Pagina inicial</a>
      </li>
      <li>
        <a href="#">Meu perfil</a>
      </li>
      <li>
        <a href="#">Meus Pedidos</a>
      </li>
      <li>
        <a href="#">Configuração</a>
      </li>
    </ul>
      
    <div class="side-nav">
<div class="line1"></div>
<div class="line2"></div>
<div class="line3"></div>
</div>
  </nav>
    <form runat="server">
            <asp:Button Text="Logout" OnClick="LogOff" ID="botaoOff" runat="server" /><br />
            <asp:Button ID="btnNovoPedido" Text="Novo pedido" onclick="redirectPedidos" runat="server" /><br /><br />
            <h1 id="title">Meus pedidos</h1><br />
        </form>
    <div id="divTable" class="table-sortable-hidden" runat="server">
    <table class="table-sortable">
    <thead>
      <tr>
        <th>ID</th>
        <th>Loja</th>
        <th>Valor</th>
      </tr>
    </thead>
    <asp:PlaceHolder ID="container" runat="server"> </asp:PlaceHolder> 
  </table>
  </div>
  <script src="../Scripts/WebForms/ScriptPedidos.js"></script>
</body>
</html>
