using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class wbData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            //  String s= Request.QueryString["data"].ToString();
            String s =  Request.Form["TextBox1"].ToString();
            String s1 = Request.Form["DropDownList1"].ToString();
           
           Response.Write(String.Format("{0}:{1}",s1,s));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}