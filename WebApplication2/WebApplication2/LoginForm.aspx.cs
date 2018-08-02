using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using WebApplication2.Models;
namespace WebApplication2
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnLogin(object sender, EventArgs e)
        {
            //SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //_sqlconn.Open();
            //SqlCommand _cmd = new SqlCommand();
            //_cmd.CommandText = "SELECT COUNT(*) FROM USERS WHERE UNAME = @UNAME AND UPASS =@UPASS";
            //_cmd.Connection = _sqlconn;
            //_cmd.Parameters.AddWithValue("@UNAME", txtEmail.Text);
            //_cmd.Parameters.AddWithValue("@UPASS", txtPassword.Text);
            //if (int.Parse(_cmd.ExecuteScalar().ToString()) >0)
            if(new Userdb().LoginValidation(new Users() { UserName = txtEmail.Text,UserPassword=txtPassword.Text}))
            {
                Session.Add("Uname", "Admin");
                Response.Redirect("WebForm1.aspx");
            }
            else {
                lblMessage.Text = "invalid User/Password";

            }
        }
    }
}