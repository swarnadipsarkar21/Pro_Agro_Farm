using System.Collections.Generic;

namespace Pro_Agro_farm
{
    public class CartItem
    {
        public string ItemName;
        public decimal Quantity;
        public string Unit;
        public decimal TotalPrice;
    }

    public static class SessionCart
    {
        public static string CustomerName = "";
        public static string Phone = "";
        public static string Address = "";
        public static string SessionId = "";
        public static List<CartItem> Items = new List<CartItem>();

        public static decimal GrandTotal()
        {
            decimal sum = 0;
            foreach (CartItem item in Items)
            {
                sum += item.TotalPrice;
            }
            return sum;
        }
    }
}