using System;
using System.Collections.Generic;
using System.Text;

namespace ErpModel
{
    public class Cart
    {
        public Cart()
        {
            Items = new List<CartItem>();
        }
        public List<CartItem> Items { get; set; }
        public int CartTotal { get; set; }

    }

    public class CartItem
    {
        public Product Product { get; set; }
        public int Qty { get; set; }
        public double LinePrice { get; set; }
    }
}
