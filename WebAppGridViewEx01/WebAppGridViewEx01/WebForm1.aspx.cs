using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppGridViewEx01.Models;

namespace WebAppGridViewEx01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
                LoadGridView();
           

        }
        public void LoadGridView() {

            Student std = new Student();
            GridView1.DataSource = std.getStudents();
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void OnUpdate(object sender, EventArgs e)
        {

        }

        protected void OnCancel(object sender, EventArgs e)
        {

        }
    }
}