using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Inventory
    {
        public Dictionary<string, int> Products { get; set; }

        public Inventory()
        {
            Products = new Dictionary<string, int>();
        }

        public void Addproduct(string product, int quantity)
        {
            Products.Add(product, quantity);
        }
        public void Removeproduct(string product)
        {
            Products.Remove(product);
        }
        public void UpdateQuantity(string product, int newQuantity)
        {
            Products[product] = newQuantity;
        }
        public void GetQuantityByProduct(string product)
        {
            foreach (var item in Products)
            {
                if(item.Key == product)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }

    }
}
