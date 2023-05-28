using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.ValueObjects
{
    public struct OrderData
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
        public List<OrdersAndGoods> OrdersAndGoods { get; set; }
    }
}