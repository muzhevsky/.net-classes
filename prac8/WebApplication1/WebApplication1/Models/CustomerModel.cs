using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Application.Models
{
    public partial class CustomerModel : DbContext
    {
        public CustomerModel()
            : base("name=DatabaseConnection")
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }

    [Table("customers")]
    public partial class Customer : IEquatable<Customer>
    {
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="некорректная фамилия")]
        [Column("surname")]
        public string Surname { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "некорректное имя")]
        [Column("name")]
        public string Name { get; set; }

        [StringLength(50)]
        [Column("patronymic")]
        public string Patronymic { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "email должен быть больше 3 символов и меньше 50")]
        [Column("email")]
        [RegularExpression("[a-zA-Z0-9]{3,35}[@][a-zA-Z0-9]{2,9}[.][a-zA-Z0-9]{2,4}", ErrorMessage = "некорректный формат email")]
        public string Email { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "номер телефона должен содержать не менее 11 и не более 15 символов")]
        [Column("phone_number")]
        [RegularExpression("[0-9]{11,15}", ErrorMessage = "некорректный номер телефона")]
        public string PhoneNumber { get; set; }

        public bool Equals(Customer other)
        {
            if (other == null) return false;
            return (other.PhoneNumber == PhoneNumber);
        }
    }
}
