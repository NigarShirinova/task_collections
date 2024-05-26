using System;
using task4;

class Program
{
    public static void Main(string[] args)
    {
      Inventory inventory = new Inventory();
        inventory.Addproduct("alma", 5);
        inventory.Addproduct("armud", 4);
        inventory.Removeproduct("alma");
        inventory.UpdateQuantity("alma", 6);
        inventory.GetQuantityByProduct("alma");
    
          
    }
}