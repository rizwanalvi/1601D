using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace GridViewImage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("INSERT INTO StudnInfo(STDNAME,STDFNAME,BATCHNO,SEMID,IMG) VALUES (@STDNAME,@STDFNAME,@BATCHNO,@SEMID,@IMG)", _sqlconn);
            _cmd.Parameters.AddWithValue("@STDNAME", TextBox1.Text);
            _cmd.Parameters.AddWithValue("@STDFNAME", TextBox2.Text);
            _cmd.Parameters.AddWithValue("@BATCHNO", TextBox3.Text);
            _cmd.Parameters.AddWithValue("@SEMID", TextBox4.Text);
          
            _cmd.Parameters.AddWithValue("@IMG", FileUpload1.FileBytes);
            _cmd.ExecuteNonQuery();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM StudnInfo", _sqlconn);
             GridView1.DataSource =  _cmd.ExecuteReader();
            GridView1.DataBind();
           
        }

        public String GetImage(Object Obj) {
            byte[] img = (byte[])Obj;
            return "data:image/png;base64," + Convert.ToBase64String(img);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM StudnInfo", _sqlconn);
            
            //ListView1.DataSource = GridView1.DataSource;
            //ListView1.DataBind();
        }
    }
}