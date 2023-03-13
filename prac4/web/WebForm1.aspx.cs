using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReference1.IService1 service; 
        protected void Page_Load(object sender, EventArgs e)
        {
            service = new ServiceReference1.Service1Client();
            CustomersGridView.DataSource = service.GetCustomers();
            CustomersGridView.DataBind();
        }


        protected void CustomersGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(CustomersGridView.SelectedRow.Cells[1].Text, out customerId)) throw new ArgumentException("the first column contains invalid id");

            var orders = service.GetOrders(customerId);

            if (orders != null || orders.Count() > 0)
            {
                OrdersGridView.Enabled = true;
                OrdersGridView.DataSource = orders;
                OrdersGridView.DataBind();
            }
            else OrdersGridView.Enabled = false;
        }
    }
}