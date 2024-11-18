using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Location(string name, int maxCap = 100)
    {
        public static long LocationCount;

        public Dictionary<Product,int> Products = new Dictionary<Product, int>();

        public int MaximumCapacity { get; private set; } = maxCap;

        public long LocationId { get; private set; } = ++LocationCount;
        public string Name { get; private set; } = name;

        public void AddProductToLocation(Product product, int Qty=1)
        {
            //TODO implement capacity handling

            if (! Products.TryAdd(product, Qty))
            {
                Products[product]++;
            }
        }
        public Product RemoveProductFromLocation(Product product, int quantity=1)
        {
            //Make it return a dict of < prod , qty > -- makes it easier when moving products!

            if ( quantity > Products[product])
            {
                throw new Exception("Cannot move that many products!");
                    //Maybe adjust to move less and wipe from location?
            }

            Products[product] -= quantity;

            return product;
        }
    }
}
