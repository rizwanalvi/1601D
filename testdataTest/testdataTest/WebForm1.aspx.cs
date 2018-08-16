using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testdataTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            string path = string.Concat(Server.MapPath("~/UploadFile/" + FileUpload1.FileName));
            FileUpload1.SaveAs(path);
            string excelCS = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);
            OleDbConnection _conn = new OleDbConnection(excelCS);
            OleDbCommand _cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", _conn);
            //if (_conn.State == System.Data.ConnectionState.Closed)
                _conn.Open();
            OleDbDataReader _dReader = _cmd.ExecuteReader();
            GridView1.DataSource = _dReader;
            GridView1.DataBind();
        }
    }
}