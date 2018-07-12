using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLogin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Response.Write("ok");
        }
        string uname = "admin";
        string upass = "admin";
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (Login1.UserName == uname && Login1.Password == upass)
            {
                Response.Redirect("~/Dashboard.aspx");
            }
            else {
                Login1.FailureText = "Invalid Password/Username";
           
            }
            
        }
    }
}