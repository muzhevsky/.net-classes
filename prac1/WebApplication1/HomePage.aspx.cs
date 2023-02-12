using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HomePage : System.Web.UI.Page
    {
        Dictionary<string, string> database = new Dictionary<string, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            database.Add("admin", "admin");
            database.Add("user", "123");
            database.Add("asd", "qwe");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!database.ContainsKey(LoginTextBox.Text))
            {
                OutputLabel.Text = "Couldnt find any user with this username";
                return;
            }

            if (database[LoginTextBox.Text] != PasswordTextBox.Text)
            {
                OutputLabel.Text = "Password doesnt match with database record";
                return;
            }

            Response.Redirect("welcome.aspx");
        }
    }
}