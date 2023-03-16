using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            var value = int.Parse(NumberTextBox.Text);
            ResultLabel.Text = $"Квадрат: {value * value}" ;
        }

        protected void RedirectButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Test.aspx");
        }

        protected void GetDataButton_Click(object sender, EventArgs e)
        {
            var source = Cache["Customers"];
            if (source != null)
            {
                GridView.DataSource = source;
                GridView.DataBind();
                return;
            }
            var service = new MyServiceReference.ServiceSoapClient();
            GridView.DataSource = service.GetCustomers();
            GridView.DataBind();
            Cache["Customers"] = GridView.DataSource;
        }
    }
}