using System.Collections.Generic;
using System.Linq;

namespace databaseProjectEDP
{
    public static class Cart
    {
        public static List<CartItem> Items = new List<CartItem>();

        public static void AddItem(string name, decimal price)
        {
            CartItem item = Items.FirstOrDefault(x => x.Name == name);

            if (item != null)
            {
                item.Quantity++;
            }
            else
            {
                Items.Add(new CartItem
                {
                    Name = name,
                    Price = price,
                    Quantity = 1
                });
            }
        }
    }
}