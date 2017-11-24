using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{/* Featutres:
    -adds item to inventory
    -removes items
    -auto adds to stack
    -sorts
    -moves 2 items
    -returns a list of items a character can equip in a certain slot
    

    // TODO --
    Possibly find a more efficient way of actually holding the data. 

   
    // NOTES
    Has no interaction with Character class at all.  This is actually probably ok but when, say, equiping items  you have to call a function to remove an item
    from here


    */
    static class Inventory
    {
        static InventoryItem[] inv = new InventoryItem[]
        {
            new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
              new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
              new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
               new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                 new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                  new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                   new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                    new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                     new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                      new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                       new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                        new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                         new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                          new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                           new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                            new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                             new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                              new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                               new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                 new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                  new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                   new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                    new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                     new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                      new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                       new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                        new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                         new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                          new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),
                                           new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1),new InventoryItem(new Item(), -1)
        }; //currently max inventory is 256, may switch to a list and give unlimited sapce.

        public static List<string> testList = new List<string>();

        public static void AddItem(Item item)
        {
            //have to find the first empty slot in the array
            for (int i = 0; i < 256; i++)
            {
                if (inv[i].item.id == item.id) //check to see if we have that item in the inventory
                {
                    if (inv[i].count < 99) // if we do and its less than 99 add 1 to count
                    {
                        inv[i].count++;
                        return;
                    }
                }

            }

            for (int i = 0; i < 256; i++)
            {
                if (inv[i].count == -1)
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
            if (inv[index] == null) //this shouldnt be possible?
            {
                Console.WriteLine("trying to remove part of inventory that isnt there");
            }

            else if (inv[index].count == -1)
            {
                Console.WriteLine("trying to remove an empty item");
            }

            else
            {
                inv[index].count--; //reduce by one

                if (inv[index].count == 0) //check to see if we removed the last in that stack
                {
                    inv[index] = new InventoryItem(new Item(), -1); //if it is add an empty item there
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

        public static void Sort() //alright im tired an this makes no sense but here we go,  
                                  //im going to set every 'empty' item with the name 'zzzzzzzzzzzzz' to be able to sort and then chnage them all
                                  //back after its done sorting.  THIS MAKES SENSE


        {
            for (int i = 0; i < 256; i++)
            {
                if (inv[i].item.name == "")
                {
                    inv[i].item.name = "zzzzzz";
                }
            }

            var test = inv.OrderBy(x => x.item.name); // i use var here to use an anonymous function to sort
            List<InventoryItem> test2 = new List<InventoryItem>(test); //howerver i had to make a hard typed list to remove the first item.

            //Console.WriteLine(test2.ElementAt(0).item.name);
            //Console.WriteLine(test2.ElementAt(1).item.name);

            inv = test2.ToArray();

            for (int i = 0; i < 256; i++)
            {
                if (inv[i].item.name == "zzzzzz")
                {
                    inv[i].item.name = "";
                }
            }



            ListInv();
        }

        public static List<Item> FindEquipable(int slot, int character) // find all the equipment in your current inventory that can be equiped to the asked for slot
                                                                       // it will return the IDs for the list

                                                                        // testing to see if it makes more sense to just return the item
        {
            List<Item> idList = new List<Item>();

            for (int i = 0; i < 256; i++) //just check all items in inventory for the correct parameters, add them to a list and return that list
            {
                if (inv[i].item.GetType().ToString() == "InventoryTest.Armor") //check to see if the slot is a piece of armor
                {
                    Armor temp = (Armor)inv[i].item; //this makes this easier?
                    if (temp.slot == slot && temp.characters == character) //now checking if its the right 'slot' and 'character'
                    {
                        idList.Add(temp);
                    }
                }
            }

            //foreach (int i in idList)
            //{
            //    Console.WriteLine(i);
            //}
            return idList;

            
        }

        public static int FindIndex(Item item)
        {
            int id = item.id;
            for(int i = 0; i < 256; i++ )
            {
                if (inv[i].item.id == id)
                    return i;
            }

            return -1;
        }

        public static void ListInv() //testing method to print out the array
        {
            int x = 0;
            foreach (InventoryItem i in inv)
            {
                if (i.count != -1)
                    Console.WriteLine(x + " " + i.item.name + " " + i.item.id + " " + i.count);

                x++;
            }

            Console.WriteLine(" ");
        }

    

}



}
