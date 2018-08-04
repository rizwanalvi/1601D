﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM MENU", con);
            DataTable dt = new DataTable();
            dAdapter.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            if (Session["Uname"] == null) {

               // Response.Redirect("LoginForm.aspx");
            }
            //NavigationMenu.Items.Add(new MenuItem("Home", "", "", "WebForm1.aspx"));
            //NavigationMenu.Items.Add(new MenuItem("Product", "", "", "product.aspx"));
            //NavigationMenu.Items.Add(new MenuItem("Contact Us", "", "", "home.aspx"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("LoginForm.aspx");

        }
    }
}