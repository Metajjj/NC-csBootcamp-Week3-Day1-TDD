using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class WarehouseInventory
    {

        public int GetTotalNumberOfProducts()
        {
            // TODO: Implement logic to get the totl number of all products in the warehouse
            return 0;
        }

        public Dictionary<string,int> GetTotalAmountofEachProduct()
        {
            // TODO Implement logic get total amount of each product in the warehouse by product ID
            return new Dictionary<string, int>();
        }

        public List<string> GetAllLocationIds()
        {
            //TODO Implement logic to get all locations ids in warehouse
            return new List<string>();
        }

        public List <string> GeAllProducts()
        {
            //TODO Implement logic to get all product ids in warehouse
            return new List<string>();
        }

        public bool LocationContainsProduct(string locationId, string productId)
        {
            //TODO Implement logic to check if locationId contains productId
            return false;
        }

        public List<string> GetLocationsContainingProduct(string productId)
        {
            //TODO Implement logic to find location that contains productId
            return new List<string>();
        }

        public Dictionary<string, int> GetProductCountsAtEachLocation()
        {
            //TODO Implement logic to generate list of product count at each location
            return new Dictionary<string, int>();
        }

        public void AddProductToLocation(string locationId, string productId)
        {
            //TODO Implment logic to add a product to location
        }

        public void AddProductstoLocation(string locationId, List<string> productId)
        {
            //TODO Implement logic to add list of products to location
        }
    }
}
