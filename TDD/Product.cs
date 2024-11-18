using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Product
    {
        static long ProductCount;
        public long ProductId { get; private set; }
        public string Name { get; private set; }

        Product(string name)
        {
            Name = name;
            ProductId = ++ProductCount;
        }
    }
}
