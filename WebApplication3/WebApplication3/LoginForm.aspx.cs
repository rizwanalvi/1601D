using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SID"] != null) {
                Session.Clear();
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (Login1.UserName == "admin" && Login1.Password == "admin") {
                Session.Add("SID", Login1.UserName);
                Response.Redirect("default.aspx");
            }
        }
    }
}