using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac2
{
    public partial class Continue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SomeLabel.Text = "login: " + Session["name"] + ", password: " + Session["password"];
        }
    }
}