using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Test : System.Web.UI.Page
    {
        string educationType;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder(64);
            builder.Append($"name: {NameTextBox.Text} <br>");
            builder.Append($"specialty: {SpecialtyListBox.Text} <br>");
            builder.Append($"favorite language: {LanguageDropDownList.Text} <br>");
            builder.Append($"education form: {educationType} <br>");

            ResultLabel.Text = builder.ToString();
        }

        protected void DistanceLearning_CheckedChanged(object sender, EventArgs e)
        {
            if (DistanceLearning.Checked) { educationType = DistanceLearning.Text; }
        }

        protected void FullTimeFormRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (FullTimeFormRadio.Checked) { educationType = FullTimeFormRadio.Text; }
        }
    }
}