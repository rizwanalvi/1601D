using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class testRepater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM MENU", con);
            DataTable dt = new DataTable();
            dAdapter.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
    }
}