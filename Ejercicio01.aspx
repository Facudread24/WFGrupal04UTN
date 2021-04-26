<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio01.aspx.cs" Inherits="WFGrupal04UTN.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="./Ejercicio01.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <div class="wrapped-div">
                <hr />
                <h2>DESTINO INICIO</h2>
                <hr />
                <div>
                    <p>PROVINCIA:</p>
                    <asp:DropDownList ID="ddl_prov_ini" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_prov_ini_SelectedIndexChanged" />
                    <p>LOCALIDAD:</p>
                    <asp:DropDownList ID="ddl_local_ini" runat="server" />
                </div>
            </div>
           <div class="wrapped-div">
                <hr />
                <h2>DESTINO FINAL</h2>
                <hr />
                <div>
                    <p>PROVINCIA:</p>
                    <asp:DropDownList ID="ddl_prov_fin" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_prov_fin_SelectedIndexChanged"/>
                    <p>LOCALIDAD:</p>
                    <asp:DropDownList ID="ddl_local_fin" runat="server"/>
                </div>
            </div>
        </div>
		
    </form>
</body>
</html>
