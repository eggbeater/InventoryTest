using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{
    public class Shop
    {
        /*TODO 
         * Every shop has to be able to do some thing.  These are
         * 1 - have a list of things for sale
         * 2 - be able to purchase items from the player 
         * 3 - be able to buy things in a specific quantity
         * 
         * i guess thats pretty much it
         * 
         * 
         * 
         */
        public List<Item> shopList;


        public Shop()
        {
            shopList = new List<Item>();
            shopList.Add(InventoryData.items[1]);
            shopList.Add(InventoryData.items[2]);
            shopList.Add(InventoryData.items[3]);

        }

       public void buyItem(Item item, int amount)
        {
            int totalCost = item.Cost * amount;
            if(totalCost > Inventory.gil)
            {
                Console.WriteLine("not enough gil");
                return;
            }
            else
            {
                for(int i = 0; i < amount; i++)
                {
                    Inventory.AddItem(item);
                }
                Inventory.gil -= totalCost;
            }
        }
    }
}
