using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCareerGuidance
{
    public partial class pg3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

            Response.Write(Request.Form["DropDownList1"].ToString() + "<br/>");
        }
    }
}