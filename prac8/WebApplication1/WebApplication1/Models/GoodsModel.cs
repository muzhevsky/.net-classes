using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Data.Entity;
using Application.ValueObjects;

namespace Application.Models
{
    public partial class GoodsModel : DbContext
    {
        public GoodsModel()
            : base("name=DatabaseConnection")
        {
        }

        public DbSet<Goods> Goods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Goods>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }

    [Table("goods")]
    public class Goods : IEquatable<Goods>
    {
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        [Column("description")]
        public string Description { get; set; }

        [Column("quantity")]
        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Column("price", TypeName = "money")]
        [Required]
        [Range(1, double.MaxValue)]
        public decimal Price { get; set; }

        public bool Equals(Goods other)
        {
            if (other == null) return false;
            return Id == other.Id;
        }
    }
}
