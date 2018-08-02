using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebSession02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> s = (List<String>)Session["data"];
            foreach (var item in s)
            {
                Response.Write(item);
            }
            
        }
    }
}