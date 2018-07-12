using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEx01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();    
            //DetailsView1.DataSource = new WebAppEx01.Models.Student().getAllStudents();
            ///DetailsView1.DataBind();
        }
        public void BindGrid() {

            GridView1.DataSource = new WebAppEx01.Models.Student().getAllStudents();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }

      
        protected void OnUpdate(object sender, EventArgs e)
        {

        }

        protected void OnCancel(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            this.BindGrid();
        }
    }
}