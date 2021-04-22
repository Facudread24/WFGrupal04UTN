<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio01.aspx.cs" Inherits="WFGrupal04UTN.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <p>DESTINO INICIO</p>
            <p>PROVINCIA:<asp:DropDownList ID="ddl_prov_ini" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_prov_ini_SelectedIndexChanged">
				</asp:DropDownList>
			</p>
            <p>LOCALIDAD:<asp:DropDownList ID="ddl_local_ini" runat="server">
				</asp:DropDownList>
			</p>
            <p>DESTINO FINAL</p>
            <p>PROVINCIA:<asp:DropDownList ID="ddl_prov_fin" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_prov_fin_SelectedIndexChanged">
				</asp:DropDownList>
			</p>
            <p>LOCALIDAD:<asp:DropDownList ID="ddl_local_fin" runat="server">
				</asp:DropDownList>
			</p>
        </div>
		
    </form>
</body>
</html>
