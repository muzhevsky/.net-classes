using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInviteForm.Models
{
    public class PartyFormModel
    {
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Некорректный телефон, мы принимаем только Xiaomi")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Придете?")]
        public bool? Attention { get; set; }
    }
}