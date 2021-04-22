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
			SqlConnection Cn_V = new SqlConnection("Data Source=localhost\\MSSQLSERVER2;Initial Catalog = Viajes;Integrated Security = True");
			Cn_V.Open();

				//DESTINO INICIO
				SqlDataAdapter adapter_V = new SqlDataAdapter("select * from Provincias",Cn_V);
				DataSet ds_V = new DataSet();

				adapter_V.Fill(ds_V, "Provincias");
				
				ddl_prov_ini.DataSource = ds_V.Tables["Provincias"];
				ddl_prov_ini.DataTextField = "NombreProvincia";
				ddl_prov_ini.DataValueField = "IdProvincia";
				ddl_prov_ini.DataBind();
			
				/*adapter_V_local.Fill(ds_V, "Localidades");
				ddl_local_ini.DataSource = ds_V.Tables["Localidades"];
				ddl_local_ini.DataTextField = "NombreLocalidad";
				ddl_local_ini.DataValueField = "IdLocalidad";
				ddl_local_ini.DataBind();
				*/
				//DESTINO FINAL

				ddl_prov_fin.DataSource = ds_V.Tables["Provincias"];
				ddl_prov_fin.DataTextField = "NombreProvincia";
				ddl_prov_fin.DataValueField = "IdProvincia";
				ddl_prov_fin.DataBind();
				/*
				ddl_local_fin.DataSource = ds_V.Tables["Localidades"];
				ddl_local_fin.DataTextField = "NombreLocalidad";
				ddl_local_fin.DataValueField = "IdLocalidad";
				ddl_local_fin.DataBind();
				*/
				Cn_V.Close();

			}
		}

		protected void ddl_prov_ini_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*SqlConnection Cn_V = new SqlConnection("Data Source=localhost\\MSSQLSERVER2;Initial Catalog = Viajes;Integrated Security = True");
			Cn_V.Open();
			SqlDataAdapter adapter_V_local = new SqlDataAdapter($"select * from Localidades where Localidades.IdProvincia={int.Parse(ddl_prov_ini.SelectedValue)}", Cn_V);
			System.Diagnostics.Debug.WriteLine(int.Parse(ddl_prov_ini.SelectedValue));
			DataSet ds_V = new DataSet();

			adapter_V_local.Fill(ds_V, "Localidades");
			ddl_local_ini.DataSource = ds_V.Tables["Localidades"];
			ddl_local_ini.DataTextField = "NombreLocalidad";
			ddl_local_ini.DataValueField = "IdLocalidad";
			ddl_local_ini.DataBind();
			Cn_V.Close();
			*/
		}
	}
}