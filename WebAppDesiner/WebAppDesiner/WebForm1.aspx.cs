using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace WebAppDesiner
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string _ConfiStr = ConfigurationManager.ConnectionStrings["1601DASPConnectionString"].ToString();
            SqlConnection _sqlConn = new SqlConnection(_ConfiStr);
            _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand();
            _cmd.CommandText = "INSERT INTO StudnInfo(STDID,STDNAME,SEMID) VALUES(@ID,@STNAME,@SEMID)";
            _cmd.Connection = _sqlConn;
            _cmd.Parameters.AddWithValue("@ID",TextBox1.Text);
            _cmd.Parameters.AddWithValue("@STNAME", TextBox2.Text);
            _cmd.Parameters.AddWithValue("@SEMID", DropDownList2.SelectedItem.Value);
            _cmd.ExecuteNonQuery();
            _sqlConn.Close();
        }
    }
}