using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace prac2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnSubmitButtonPress(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session.Add("name", LoginTextBox.Text);
                Session.Add("password", PasswordTextBox.Text);
                Response.Redirect("Continue.aspx");
            }
        }

    }
}