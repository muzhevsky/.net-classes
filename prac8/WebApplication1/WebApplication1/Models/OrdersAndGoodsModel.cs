using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Application.Models
{
    public partial class OrdersAndGoodsModel : DbContext
    {
        public OrdersAndGoodsModel()
            : base("name=DatabaseConnection")
        {
        }

        public DbSet<OrdersAndGoods> OrdersAndGoods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }

    [Table("orders_and_goods")]
    public partial class OrdersAndGoods
    {
        [Key]
        [Column("order_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column("goods_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        public OrdersAndGoods()
        {

        }
        public OrdersAndGoods(int orderId, int goodsId, int quantity)
        {
            OrderId = orderId;
            GoodsId = goodsId;
            Quantity = quantity;
        }
    }
}
