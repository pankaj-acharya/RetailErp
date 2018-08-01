using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Text;
using ErpModel;

namespace ErpServices
{
    public interface ICartService
    {
        //Create
        Cart Add(int productId,int qty,int sessionId);
        //Read
        Cart Get(int sessionId);
        //Update
        //Cart Update();
        //Delete
         void ClearCart();

        //helpers
        Cart ApplyCoupon();
    }
}
