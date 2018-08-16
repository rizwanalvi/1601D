using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace ExcelDataHandling
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            SqlConnection _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlConn.Open();
            SqlCommand _Sqlcmd = new SqlCommand("SELECT * FROM StudnInfo", _sqlConn);
            GridView1.DataSource = _Sqlcmd.ExecuteReader();
            GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = string.Concat(Server.MapPath("~/UploadFile/" + FileUpload1.FileName));
            FileUpload1.SaveAs(path);
            // Connection String to Excel Workbook  
            string excelCS = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);
            OleDbConnection _conn = new OleDbConnection(excelCS);
            if(_conn.State ==System.Data.ConnectionState.Closed)
            _conn.Open();
            OleDbCommand _cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", _conn);
            OleDbDataReader _dReader = _cmd.ExecuteReader();
           // GridView1.DataSource = _dReader;
            //GridView1.DataBind();
            
            SqlConnection _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlConn.Open();
            SqlBulkCopy _sqlBulk = new SqlBulkCopy(_sqlConn);
            _sqlBulk.DestinationTableName = "StudnInfo";
            _sqlBulk.ColumnMappings.Add("STDNAME", "STDNAME");
            _sqlBulk.ColumnMappings.Add("STDFNAME", "STDFNAME");
            _sqlBulk.WriteToServer(_dReader);

            SqlCommand _Sqlcmd = new SqlCommand("SELECT * FROM StudnInfo", _sqlConn);
            GridView1.DataSource = _Sqlcmd.ExecuteReader();
            GridView1.DataBind();
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();

        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            String FileName = "text_"+DateTime.Now+".xls";
            StringWriter strwriter = new StringWriter();
            HtmlTextWriter htmlText = new HtmlTextWriter(strwriter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition","attachment;filename="+FileName);
            GridView1.GridLines = GridLines.Both;
            GridView1.HeaderStyle.Font.Bold = true;
            GridView1.RenderControl(htmlText);
            Response.Write(strwriter.ToString());
            Response.End();
        }
    }
}