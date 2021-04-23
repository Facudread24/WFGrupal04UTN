<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio03b.aspx.cs" Inherits="WFGrupal04UTN.Ejercicio03b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gv_Libros" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:LinkButton ID="link_Tema" runat="server" OnClick="link_Tema_Click">Consultar Otro Tema </asp:LinkButton>
        </div>
    </form>
</body>
</html>
