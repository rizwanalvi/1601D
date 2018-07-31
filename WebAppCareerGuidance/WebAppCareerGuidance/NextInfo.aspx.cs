using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCareerGuidance
{
    public partial class NextInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            LAB01.Text = Session["STD_NAME"].ToString();
                     
        }
    }
}