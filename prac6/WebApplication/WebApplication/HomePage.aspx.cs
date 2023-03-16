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
        private static DateTime _lastCacheUpdate;
        private const int _refreshInterval = 5;
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
            if (source != null && DateTime.Now.Subtract(_lastCacheUpdate).Seconds < _refreshInterval)
            {
                GridView.DataSource = source;
                GridView.DataBind();
                return;
            }

            var service = new MyServiceReference.ServiceSoapClient();
            GridView.DataSource = service.GetCustomers();
            GridView.DataBind();
            Cache["Customers"] = GridView.DataSource;
            _lastCacheUpdate = DateTime.Now;
        }
    }
}