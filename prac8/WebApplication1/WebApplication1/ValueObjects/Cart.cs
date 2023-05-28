using Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.ValueObjects
{
    public class Cart
    {
        public Cart() { GoodsInCart = new List<OrderItemDetails>(); }
        public List<OrderItemDetails> GoodsInCart{ get; set; }
    }
}