using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace WebAppRepater
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            SqlConnection _conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter dAdapter = new SqlDataAdapter("spGetUniList", _conn);
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            Repeater1.DataSource = dTable;
            Repeater1.DataBind();
            

                GridView1.DataSource = dTable;
                GridView1.DataBind();

                DropDownList1.DataSource = dTable;
                DropDownList1.DataTextField = "UN_NAME";
                DropDownList1.DataBind();
               


            }
        }

        protected void OnSelected(object sender, EventArgs e)
        {

        }

        protected void Select(object sender, CommandEventArgs e)
        {
          
        }
    }
}