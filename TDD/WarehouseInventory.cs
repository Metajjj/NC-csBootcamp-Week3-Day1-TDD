using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class WarehouseInventory
    {

        public List<Location> WarehouseLocations = new List<Location> ();



        public long GetTotalNumberOfProducts()
        {
            // TODO: Implement logic to get the totl number of all products in the warehouse

            long productCountInLocation = 0;

            foreach (Location location in WarehouseLocations)
            {
                foreach (var kvp in location.Products)
                {
                    productCountInLocation+= kvp.Value;
                }
            }

            return productCountInLocation;
        }

        public Dictionary<string,int> GetTotalAmountofEachProduct()
        {
            // TODO Implement logic get total amount of each product in the warehouse by product ID
            Dictionary<string, int> prod2qty = new Dictionary<string, int> ();

            foreach (Location location in WarehouseLocations)
            {
                foreach (var kvp in location.Products)
                {
                    if (! prod2qty.TryAdd(kvp.Key.Name,kvp.Value)) 
                    {
                        prod2qty[kvp.Key.Name] += kvp.Value;
                    }
                }
                
            }


            return prod2qty;
        }

        public List<string> GetAllLocationIds()
        {
            //TODO Implement logic to get all locations ids in warehouse
            return WarehouseLocations.Select(location => location.LocationId+"").ToList();
        }

        public List <string> GetAllProducts()
        {
            //TODO Implement logic to get all product ids in warehouse

            List<string> IDs = new List<string> ();

            foreach (Location location in WarehouseLocations)
            {
                foreach(var kvp in location.Products)
                {
                    IDs.Add(kvp.Key.Name);
                }
            }

            return IDs.Distinct().ToList(); //Distinct = no dupes!
        }

        public bool LocationContainsProduct(string locationId, string productId)
        {
            //TODO Implement logic to check if locationId contains productId

            foreach (Location location in WarehouseLocations)
            {
                if(location.LocationId+"" != locationId)
                { continue; }

                foreach( var prod in location.Products.Keys)
                {
                    if(prod.ProductId+"" == productId)
                    {
                        return true;
                    }
                }
                
            }

            return false;
        }

        public List<Location> GetLocationsContainingProduct(string productId)
        {
            //TODO Implement logic to find location that contains productId
            List<Location> locs = new List<Location>();

            foreach (Location location in WarehouseLocations)
            {
                if (location.LocationId + "" != locationId)
                { continue; }

                foreach (var prod in location.Products.Keys)
                {
                    if (prod.ProductId+"" == productId) {
                        locs.Add(location);
                    }
                }
            }

            return locs;
        }

        public Dictionary<Location, int> GetProductCountsAtEachLocation()
        {
            //TODO Implement logic to generate list of product count at each location

            var dic = new Dictionary<Location, int>();

            foreach (var location in WarehouseLocations)
            {
                dic.Add(location, location.Products.Count);
                //If error, multiple locations the same!
            }

            return dic;
        }

        public void AddProductToLocation(string locationId, Product product, int qty=1)
        {
            //TODO Implment logic to add a product to location
            foreach (Location location in WarehouseLocations)
            {
                if (location.LocationId+"" == locationId)
                {
                    location.AddProductToLocation(product, qty);
                }
            }
        }

        public void AddProductstoLocation(string locationId, List<Product> product)
        {
            //TODO Implement logic to add list of products to location
            foreach(var prod in product)
            {
                AddProductToLocation(locationId,prod);
            }
        }
 
        private void RemoveProductsFromLocation(string LocationID, string ProductID) {
            foreach (Location location in WarehouseLocations)
            {
                if (location.LocationId+"" == LocationID)
                {
                    foreach(var kvp in location.Products)
                    {
                        if(kvp.Key.ProductId+"" == ProductID)
                        {
                            location.RemoveProductFromLocation(kvp.Key,kvp.Value);
                        }
                    }
                }
            }
        }
        private int LocationCurrentCapacity(string locID)
        {
            foreach (Location location in WarehouseLocations)
            { 
                if (location.LocationId+"" == locID)
                {
                    int i = 0;

                    foreach(var kvp in location.Products)
                    {
                        i += kvp.Value;
                    }
                    return i;
                }
            }

            return 0; //Grab all products in loc
        }

        //Move product to new location
        private void MoveProduct(string locLeaving, string locArriving, string ProductID)
        {
            Location locL=null, locA=null;
            foreach(Location location in WarehouseLocations)
            {
                locL = (location.LocationId+"" == locLeaving) ? location : locL;
                locA = (location.LocationId + "" == locLeaving) ? location : locA;
            }

                        //Grabs product of ID
            var product = locL.Products.Where(kvp => { return kvp.Key.ProductId + "" == ProductID; }).ToList()[0];

            locA.AddProductToLocation(locL.RemoveProductFromLocation(product));

        }

        //TODO add innate methods to cleanup so many `foreach in location` WET code
        //TODO sort statics when removing locs/classes

        private void CleanLocation(string locID)
        {
            foreach (Location location in WarehouseLocations)
            {
                if (location.LocationId + "" == locID)
                { location.Products.Clear(); }
            }
        }
        private void EmptyWarehouse() {
            WarehouseLocations.Clear();
        }
    }
}
