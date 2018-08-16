using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
namespace ImportDataFromExcel
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = string.Concat(Server.MapPath("~/UploadFile/" + FileUpload1.FileName));
            FileUpload1.SaveAs(path);
            // Connection String to Excel Workbook  
            string excelCS = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);
            //SqlBulkCopy oSqlBulk = null;

            // SET A CONNECTION WITH THE EXCEL FILE.
            OleDbConnection myExcelConn = new OleDbConnection(excelCS);
            try
            {
                myExcelConn.Open();
              // GET DATA FROM EXCEL SHEET.
                OleDbCommand objOleDB =
                    new OleDbCommand("SELECT *FROM [Sheet1$]", myExcelConn);

                // READ THE DATA EXTRACTED FROM THE EXCEL FILE.
                OleDbDataReader objBulkReader = null;
                objBulkReader = objOleDB.ExecuteReader();
               GridView1.DataSource = objBulkReader;
               GridView1.DataBind();
                // SET THE CONNECTION STRING.
                string sCon = @"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
               
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    con.Open();
              // FINALLY, LOAD DATA INTO THE DATABASE TABLE.
                    //using (SqlBulkCopy oSqlBulk = new SqlBulkCopy(con)) { 
                    //    oSqlBulk.DestinationTableName = "StudnInfo"; // TABLE NAME.
                    //      oSqlBulk.ColumnMappings.Add("STDNAME", "STDNAME");                
                    //oSqlBulk.WriteToServer(objBulkReader);
                    //    oSqlBulk.Close();
                    //}
                }

                //   lblConfirm.Text = "DATA IMPORTED SUCCESSFULLY.";
                //   lblConfirm.Attributes.Add("style", "color:green");

            }
            catch (Exception ex)
            {

              //  lblConfirm.Text = ex.Message;
              //  lblConfirm.Attributes.Add("style", "color:red");

            }
            finally
            {
                // CLEAR.
               
               
                myExcelConn.Close();
                myExcelConn = null;
            }

        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "Vithal" + DateTime.Now + ".xls";
            StringWriter strwritter = new StringWriter();
            HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
            GridView1.GridLines = GridLines.Both;
            GridView1.HeaderStyle.Font.Bold = true;
            GridView1.RenderControl(htmltextwrtter);
            Response.Write(strwritter.ToString());
            Response.End();
        }
    }
}