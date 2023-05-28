using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Application.Models
{
    public partial class OrdersModel : DbContext
    {
        public OrdersModel()
            : base("name=DatabaseConnection")
        {
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }

    [Table("orders")]
    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id")]
        public int Id { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        public Order()
        {

        }
        public Order(int customerId)
        {
            CustomerId = customerId;
        }
    }
}
