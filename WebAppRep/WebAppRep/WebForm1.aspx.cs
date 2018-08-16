using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace WebAppRep
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                SqlConnection _conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlDataAdapter dAdapter = new SqlDataAdapter("spGetUniList", _conn);
                DataTable dt = new DataTable();
                dAdapter.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                 DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        public DataTable GetDataTable() {

            SqlConnection _conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter dAdapter = new SqlDataAdapter("spGetUniList", _conn);
            DataTable dt = new DataTable();
            dAdapter.Fill(dt);
            return dt;

        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            DropDownList dr = GridView1.Rows[e.NewEditIndex].Cells[1].FindControl("DropDownList3") as DropDownList;
            dr.DataSource = GetDataTable();
            dr.DataBind();
        }
    }
}