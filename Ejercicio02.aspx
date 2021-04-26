<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio02.aspx.cs" Inherits="WFGrupal04UTN.Ejercicio02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="./Ejercicio02.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <div class="wrapped-div">
                <h2>Id Producto: </h2>
                <div>
                    <asp:DropDownList ID="ddlProducto" runat="server" Height="19px" Width="136px">
                        <asp:ListItem Value="=">Igual a:</asp:ListItem>
                        <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                        <asp:ListItem Value="&lt;">Menor a</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtProducto" runat="server" Width="129px"></asp:TextBox>

                </div>
            </div>
            <div class="wrapped-div">
                <h2>Id Categoria: </h2>
                <div>
                    <asp:DropDownList ID="ddlCategoria" runat="server" Height="16px" Width="137px">
                        <asp:ListItem Value="=">Igual a:</asp:ListItem>
                        <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                        <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtCategoria" runat="server" Width="129px"></asp:TextBox>
                </div>
            </div>
            <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
            <asp:Button ID="btnQuitar" runat="server" OnClick="btnQuitar_Click" Text="Quitar Filtro" />
            <asp:GridView ID="grdDatos" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
