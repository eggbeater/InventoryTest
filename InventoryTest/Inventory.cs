using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{/* OK, so inventory is going to be a static class because we are going to only have 1 'inventory' 
    The class will be pretty much just a list with added functions

    The max of one item you can have is 99, Items are auto added to a 'stack'
    Might want to find a way to have more than one stack of the same thing. 

    Might also include money
    Might also include a way to see what characters have equiped.


    THOUGHTSSSSSSSSSS:
    might rewrite the dictiony to only be two ints, one for the ID one for the ammount and just use another
    data structure to hold all the items. in fact i think i should prolly do this
    */
    static class Inventory
    {
        static InventoryItem[] inv = new  InventoryItem[255]; //currently max inventory is 256, may switch to a list and give unlimited sapce.
        public static List<string> testList = new List<string>();

        public static void AddItem(Item item)
        {
            //right now just add item to the array, do not auto sort. 

            //have to find the first empty slot in the array
            for(int i = 0; i < 255; i++)
            {
                if(inv[i] == null)
                {
                    inv[i] = new InventoryItem(item, 1); // add item and break loop
                    break;
                }

               /* else
                {
                    Console.WriteLine("inventory at " + i + " is full:  It has " + inv[i].item.name);
                } */
            }
            
        }

        public static void RemoveItem(int index) //prolly going to be the Value at the index -1
        {
            if(inv[index] == null) //this shouldnt be possible?
            {
                Console.WriteLine("trying to remove part of inventory that isnt there");
            }

            else
            {
                inv[index].count--; //reduce by one

                if(inv[index].count == 0) //check to see if we removed the last in that stack
                {
                    inv[index] = null;
                }

            }
        }

        public static void MoveItems(int index1, int index2) //swap two items
        {
            // we shouldnt' have to check to see if these are null because you can just move empty spots?
            InventoryItem temp = inv[index1];
            inv[index1] = inv[index2];
            inv[index2] = temp;
        }
        public static void ListInv() //testing method to print out the array
        {
            foreach(InventoryItem i in inv)
            {
                if(i != null)
                  Console.WriteLine(i.item.name + " " + i.item.id + " " + i.count);
            }
        }

    }





    /*
        public static Dictionary<Item, int> d = new Dictionary<Item, int>();
        public static Dictionary<string, int> d2 = new Dictionary<string, int>();

        static Inventory()
        {
            
        }

        public static void addItem(Item item)
        {
           // inventory.Add(item);
            if(d.ContainsKey(item)) //see if we have the item
            {
               d[item]++; // if we have at least 1, add 1 to the ammount
               d2[item.name]++; 


            }
            else
            {
                d.Add(item, 1);
                d2.Add(item.name, 1);
            }
        }

        public static void removeItem(Item item)
        {
            if (d.ContainsKey(item)) // see if we have the item, and we should if we are trying to delete it
            {
                if (d[item] == 1) //if we currently have one of the item, remove from inventory completely. 
                {

                }
            
            }
        }


        
    } */
}
