using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInviteForm.Models
{
    public class ParticipantModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Некорректный телефон")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Выберите опцию")]
        public bool? Attention { get; set; }

    }
}