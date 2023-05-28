using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.ValueObjects
{
    public struct OrderItemDetails
    {
        public Goods Goods { get; set; }
        public int Quantity { get; set; }
    }
}