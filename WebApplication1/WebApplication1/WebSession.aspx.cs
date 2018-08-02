using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> _LST = new List<string>();
            _LST.Add("aHMED");
            _LST.Add("kamran");
            _LST.Add("Noman");
            Session.Add("data", _LST);
            Response.Redirect("WebSession02.aspx");
        }
    }
}