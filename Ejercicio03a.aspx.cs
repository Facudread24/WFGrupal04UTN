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
    public partial class Ejercicio03 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                ddl_Tema.DataSource = Consulta("select * from Temas");
                ddl_Tema.DataTextField = "Tema";
                ddl_Tema.DataValueField = "IdTema";
                ddl_Tema.DataBind();
                ddl_Tema.Items.Insert(0, new ListItem("SELECCIONAR TEMA", "0"));
               
            }
        }

        public DataSet Consulta(string sqlQuery) //Idea prestada del ejercicio 1 :P
        {
            SqlConnection cnLibreria = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = Libreria; Integrated Security = True");
            cnLibreria.Open();

            SqlCommand cmd = new SqlCommand(sqlQuery, cnLibreria);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            cnLibreria.Close();

            return ds;
        }

        protected void link_Libros_Click(object sender, EventArgs e)
        {
            if(ddl_Tema.SelectedIndex != 0) {
                Server.Transfer("Ejercicio03b.aspx");
            }
            
        }
    }
}