using ErpModel;

namespace ErpServices
{
    public interface ICartService
    {
        //Create
        Cart Add(int productId,int qty,string cartGUID);

        //Read
        Cart Get(int cartGUID);

        //Update
        //Cart Update();

        //Delete
         void ClearCart();

        //helpers
        Cart ApplyCoupon();
    }
}
