using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Navigation_SiteMap
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        Dictionary<String, String> _Menu = new Dictionary<string, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                _Menu.Add("APPLE", "Apple.aspx");
                _Menu.Add("Mango", "Apple.aspx");
                _Menu.Add("Orange", "Apple.aspx");
                _Menu.Add("PineApple", "Apple.aspx");
                foreach (var item in _Menu)
                {
                Menu1.Items.Add(new MenuItem(item.Key,"apple","",item.Value));

                }

               
            }
        }
    }
}