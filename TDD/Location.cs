using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Location
    {
        public static long LocationCount;

        public Dictionary<Product,int> Products = new Dictionary<Product, int>();

        public int MaximumCapacity { get; private set; }

        public long LocationId { get; private set; }
        public string Name { get; private set; }

        Location(string name, int maxCap=100)
        {
            Name = name;
            LocationId = ++LocationCount;
            MaximumCapacity = maxCap;
        }

        public void AddProductToLocation(Product product, int Qty=1)
        {
            //TODO implement capacity handling

            if (! Products.TryAdd(product, Qty))
            {
                Products[product]++;
            }
        }
        public void RemoveProductFromLocation(Product product, int quantity=1)
        {
            //Make it return a dict of < prod , qty > -- makes it easier when moving products!

            if ( quantity > Products[product])
            {
                throw new Exception("Cannot move that many products!");
                    //Maybe adjust to move less and wipe from location?
            }

            Products[product] -= quantity;
        }
    }
}
