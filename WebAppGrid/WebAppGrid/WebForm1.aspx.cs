using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppGrid.Models;
namespace WebAppGrid
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();  
        }
        public void LoadGridView() {


            GridView1.DataSource = new Student().getAllStudents();
            GridView1.DataBind();
        }
        protected void OnUpdate(object sender, EventArgs e)
        {

        }

        protected void OnCancel(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            this.LoadGridView();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.LoadGridView();
                

        }
    }
}