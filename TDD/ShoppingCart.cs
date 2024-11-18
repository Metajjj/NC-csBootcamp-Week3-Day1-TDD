using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class ShoppingCart
    {

        private Dictionary<string, decimal> items = new Dictionary<string, decimal>();

        public void AddItem(string itemName, decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative");
            }


            if (items.ContainsKey(itemName))
            {
                items[itemName] += price;
            }
            else
            {
                items[itemName] = price;
            }
        }

        public decimal CalculatTotalPrice()
        {
            decimal total = 0;
            foreach (var item in items.Values)
            {
                total += item;
            }
            return total;
        }

        public void ApplyDiscount(decimal discount, string item)
        {
            items[item] -= (100 * discount);
        }



    }
}
