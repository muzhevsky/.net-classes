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
            int age = 0;
            int.TryParse(AgeTextBox.Text, out age);

            SignUpData signUpData = new SignUpData()
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                ConfirmPassword = ConfirmPasswordTextBox.Text,
                Email = EmailTextBox.Text,
                Age = age
            };

            Dictionary<string, Label> dictionary = new Dictionary<string, Label>
            {
                { "Login", InvalidLoginLabel },
                { "Password", InvalidPasswordLabel },
                { "ConfirmPassword", InvalidConfirmPasswordLabel },  // TODO: не работает сравнение пароля и подтверждения
                { "Email", InvalidEmailLabel },
                { "Age", InvalidAgeLabel }
            };

            var res = new List<ValidationResult>();
            var ctx = new ValidationContext(signUpData);

            foreach(var item in dictionary.Values)
            {
                item.Text = "";
            }

            if (!Validator.TryValidateObject(signUpData, ctx, res, true))
            {
                foreach(var item in res)
                    foreach (var test in item.MemberNames)
                        dictionary[test].Text = item.ErrorMessage;
            }
        }

    }
}