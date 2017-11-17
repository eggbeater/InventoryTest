using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{
     static class InventoryData
    {
        public static Item[] items = new Item[]
           {

                new Potion(0, "Cure1", "Heals 50 HP", 50, 0, 0),
                new Potion(1, "Cure2", "Heals 250 HP", 250, 0, 0),
                new Potion(2, "Cure3", "Heals 2250 HP", 2250, 0, 0),
                new Potion(3, "Cure4", "Heals all HP", 9999, 0, 0),
                new Potion(4, "Ether1", "Restores 50 MP", 0, 50, 0),
                new Potion(5, "Ether2", "Resotres 150 MP", 0, 150, 0),
                new Armor(6, "Cap", "Light head protection", 2, 1, 1),
                new Armor(7, "Robe", "Light body protection", 2, 2, 1),
                new Armor(8, "Gloves", "Light hand protection", 2, 3, 1),


           };


    }
}
