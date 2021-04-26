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
    public partial class Ejercicio02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                CargarDatos();
            }
            
        }

        void CargarDatos()
            {
            SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
            cn.Open();
            string consulta = "select IdProducto as 'ID Producto', NombreProducto as 'Nombre Producto', IdProveedor as 'ID Proveedor', " +
                "CantidadporUnidad as 'Cantidad x Unidad', UnidadesEnExistencia as 'Unidades en Existencia', UnidadesEnPedido as 'Unidades en Pedido', " +
                "NivelNuevoPedido as 'Nivel Nuevo Pedido', Suspendido " +
                "FROM Productos";
            SqlCommand cmd = new SqlCommand(consulta, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            grdDatos.DataSource = dr;
            grdDatos.DataBind();

            cn.Close();
            }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            txtProducto.Text = txtProducto.Text.Trim();
            txtCategoria.Text = txtCategoria.Text.Trim();

            if (txtProducto.Text == "" && txtCategoria.Text == "")
            {
                CargarDatos();
            }

            else 
            {
                SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    SqlDataReader dr;

                           if(txtProducto.Text != "" && txtCategoria.Text != "")
                            {
                                cmd.CommandText = $"select * from Productos where IdProducto {ddlProducto.SelectedValue} {txtProducto.Text} AND IdCategoría {ddlCategoria.SelectedValue} {txtCategoria.Text}";
                                 dr = cmd.ExecuteReader();

                                grdDatos.DataSource = dr;
                                grdDatos.DataBind();

                            }
                             else if(txtProducto.Text != "")
                               {
                                        cmd.CommandText = $"select * from Productos where IdProducto {ddlProducto.SelectedValue} {txtProducto.Text}";
                                        dr = cmd.ExecuteReader();

                                        grdDatos.DataSource = dr;
                                        grdDatos.DataBind();
                              }
                                 else {
                                        cmd.CommandText = $"select * from Productos where IdCategoría {ddlCategoria.SelectedValue} {txtCategoria.Text}";
                                        dr = cmd.ExecuteReader();

                                        grdDatos.DataSource = dr;
                                        grdDatos.DataBind();
                                  }
                                 
                

                cn.Close(); 
            }
            txtProducto.Text = "";
            txtCategoria.Text = "";
        }

        protected void btnQuitar_Click(object sender, EventArgs e)
        {
            txtProducto.Text = "";
            txtCategoria.Text = "";
            CargarDatos();
        }
    }
}