using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace WebAppGridViewWithdb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }


        private void LoadDataGridview() {
           
            SqlConnection sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlconn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM StudnInfo";
           SqlDataReader dReader = cmd.ExecuteReader();
            GridView1.DataSource = dReader;
            GridView1.DataBind();
        }

      

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadDataGridview();
        }

        protected void OnCancel(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadDataGridview();
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow dRow = GridView1.Rows[e.RowIndex] as GridViewRow;
            TextBox txtName =  dRow.Cells[1].Controls[0] as TextBox;
            TextBox txtId = dRow.Cells[2].Controls[0] as TextBox;
            int id = Int32.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
            String s = txtName.Text;
         }
    }
}