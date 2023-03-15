using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Calculator : System.Web.UI.UserControl
    {
        public long Result
        {
            get { return CalculatorHandler.GetResult(Calculator_TB.Text); }
            private set { }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Calculator_TB.ReadOnly = true;
        }

        protected void CommonButton_Click(object sender, EventArgs e)
        {
            Calculator_TB.Text += ((Button)sender).Text;
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            Calculator_TB.Text = "";
        }

        protected void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (Calculator_TB.Text.Length < 0) return;
            Calculator_TB.Text = Calculator_TB.Text.Substring(0, Calculator_TB.Text.Length - 1);
        }
    }
}