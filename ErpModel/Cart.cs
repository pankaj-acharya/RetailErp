using System;
using System.Collections.Generic;
using System.Text;

namespace ErpModel
{
    public class Cart
    {
        public List<CartItems> Items { get; set; }
        public int CartTotal { get; set; }

    }

    public class CartItems
    {
        public Product Product { get; set; }
        public int Qty { get; set; }
        public double LinePrice { get; set; }
    }
}
