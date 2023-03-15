using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var service = new MyService.ServiceSoapClient();
            CustomersGridView.DataSource = service.GetCustomers();
            CustomersGridView.DataBind(); 
        }

        protected void ResultButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = Calculator.Result.ToString();
        }


    }
}