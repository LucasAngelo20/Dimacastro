<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPedidoAdm.aspx.cs" Inherits="Dimacastro_final.PaginaPedidoAdm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Pagina pedidos admin</h1><br /><br />
            <asp:Button Text="Logout" OnClick="LogOff" ID="botaoOff" runat="server" /><br />
        </div>
        <div id="divTable" class="table-sortable-hidden" runat="server">
    <table class="table-sortable">
    <thead>
      <tr>
        <th>ID</th>
        <th>Loja</th>
        <th>Valor</th>
          <th>Usuario</th>
      </tr>
    </thead>
    <asp:PlaceHolder ID="container" runat="server"> </asp:PlaceHolder> 
  </table>
</div>
    </form>
</body>
</html>
