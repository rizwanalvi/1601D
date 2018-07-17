using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace WebAppCareerGuidance
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection _sqlConn = null;
        SqlCommand _cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string strConn = ConfigurationManager.ConnectionStrings["asp1601d"].ConnectionString;
            _sqlConn = new SqlConnection(strConn);
            if (!IsPostBack) { 
              
                _sqlConn.Open();
                _cmd = new SqlCommand("SELECT DISTINCT(PROG_NAME) FROM UN_PROGRAMS", _sqlConn);
                DropDownList1.DataSource = _cmd.ExecuteReader();
                DropDownList1.DataTextField = "PROG_NAME";
                DropDownList1.DataValueField = "PROG_NAME";
                DropDownList1.DataBind(); 
                _sqlConn.Close();
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            _sqlConn.Open();
            _cmd = new SqlCommand(@"SELECT uL.UN_ID,uL.UN_NAME,uP.PROG_NAME,UP.ADM_PERCENT FROM UN_LIST ul 
INNER JOIN UN_PROGRAMS up
ON UL.UN_ID = uP.UN_ID
WHERE PROG_NAME = @PROG_NAME", _sqlConn);
            _cmd.Parameters.AddWithValue("@PROG_NAME", DropDownList1.SelectedValue.ToString());
            GridView1.DataSource = _cmd.ExecuteReader();
            GridView1.DataBind();
            _sqlConn.Close();
        }
    }
}