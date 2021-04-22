using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WFGrupal04UTN
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(IsPostBack==false){

				ddl_prov_ini.DataSource = Consulta("select* from Provincias");
				ddl_prov_ini.DataTextField = "NombreProvincia";
				ddl_prov_ini.DataValueField = "IdProvincia";
				ddl_prov_ini.DataBind();
				ddl_prov_ini.Items.Insert(0, new ListItem("SELECCIONAR PROVINCIA", "0"));

			}
		}

		public DataSet Consulta(string querySql)	// Metodo para hacer consultas
		{
			string srtconn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = Viajes;Integrated Security = True";
			SqlConnection Cn_V = new SqlConnection(srtconn);
			Cn_V.Open();
			SqlCommand cmd = new SqlCommand(querySql, Cn_V);
			SqlDataAdapter adapter_V_local = new SqlDataAdapter(cmd);
			DataSet ds_V = new DataSet();
			adapter_V_local.Fill(ds_V);
			Cn_V.Close();
			return ds_V;
		}
		protected void ddl_prov_ini_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Cambio para mostrar todas las localidades de la provincia
			int provId = int.Parse(ddl_prov_ini.SelectedValue);	// id de la provincia que se selecciona
			ddl_local_ini.DataSource = Consulta($"select * from Localidades where Localidades.IdProvincia={provId}");
			ddl_local_ini.DataTextField = "NombreLocalidad";
			ddl_local_ini.DataValueField = "IdLocalidad";
			ddl_local_ini.DataBind();
			ddl_local_ini.Items.Insert(0,new ListItem("Seleccionar Localidad", "0"));

			// Selecciona todos menos el valor elegido
			ddl_prov_fin.DataSource = Consulta($"select * from Provincias where IdProvincia!={provId}");
			ddl_prov_fin.DataTextField = "NombreProvincia";
			ddl_prov_fin.DataValueField = "IdProvincia";
			ddl_prov_fin.DataBind();
			ddl_prov_fin.Items.Insert(0, new ListItem("Seleccionar Provincia", "0"));
		}

		protected void ddl_prov_fin_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Cambio para mostrar todas las localidades de la provincia x2
			int provId = int.Parse(ddl_prov_fin.SelectedValue);
			ddl_local_fin.DataSource = Consulta($"select * from Localidades where Localidades.IdProvincia={provId}");
			ddl_local_fin.DataTextField = "NombreLocalidad";
			ddl_local_fin.DataValueField = "IdLocalidad";
			ddl_local_fin.DataBind();
			ddl_local_fin.Items.Insert(0, new ListItem("Seleccionar Localidad", "0"));
		}
	}
}