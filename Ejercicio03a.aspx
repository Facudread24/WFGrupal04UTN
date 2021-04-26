<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio03a.aspx.cs" Inherits="WFGrupal04UTN.Ejercicio03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="./Ejercicio03.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapped">
            <p>Seleccionar Tema: </p> 
                <asp:DropDownList ID="ddl_Tema" runat="server"> </asp:DropDownList>
            <div>
                <asp:LinkButton ID="link_Libros" runat="server" OnClick="link_Libros_Click">Ver Libros</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
