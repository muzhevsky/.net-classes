using System.ComponentModel.DataAnnotations;

namespace prac2
{
    public class SignUpData
    {
        [Required (ErrorMessage = "Login can not be empty")]
        [RegularExpression(@"\w{5,25}", ErrorMessage = "Login should consist of latin letters, digits, \"_\" char and has 5 or more chars")]
        public string Login { get; set; }

        [Required (ErrorMessage = "Password can not be empty")]
        [RegularExpression(@"\w{6,25}", ErrorMessage = "Password should consist of 6 or more chars")]
        public string Password { get; set; }

        [Required (ErrorMessage = "Password confirmation can not be empty")]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        public string ConfirmPassword { get; set; }

        [Required (ErrorMessage = "Email can not be empty")]
        [RegularExpression(@"\w{3,20}[@]{1}\w{2,10}[.]{1}\w{2,5}", ErrorMessage = "Invalid e-mail format")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Age can not be empty")]
        [Range(18, 25)]
        public int Age { get; set; }
    }
}