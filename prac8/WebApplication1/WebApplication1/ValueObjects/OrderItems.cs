using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.ValueObjects
{
    public struct OrderItems
    {
        public int Id;
        public List<OrderItemDetails> Details;
    }
}