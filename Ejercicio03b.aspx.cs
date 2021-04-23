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
    public partial class Ejercicio03b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {

                string temaelegido = ((DropDownList)PreviousPage.FindControl("ddl_Tema")).SelectedIndex.ToString();// Busco la ddl de la pagina anterior agarro su indice y la guardo en una variable tipo string
                gv_Libros.DataSource = Consulta($"SELECT IdLibro, IdTema, Titulo, Precio, Autor FROM Libros WHERE IdTema = {temaelegido}");
                gv_Libros.DataBind();

            }
        }

        public DataSet Consulta(string sqlQuery) //Idea prestada del ejercicio 1 :P
        {
            SqlConnection cnLibros = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = Libreria; Integrated Security = True");
            cnLibros.Open();

            SqlCommand cmd = new SqlCommand(sqlQuery, cnLibros);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            cnLibros.Close();

            return ds;
        }

        protected void link_Tema_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio03a.aspx");
        }
    }
}