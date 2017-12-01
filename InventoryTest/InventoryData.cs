using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{
    //class made to hold all Items available int the game
     public static class InventoryData
    {
        public static Item[] items = new Item[]
           {
                new Potion(),
                new Potion(1, "Cure1", "Heals 50 HP", 50, 50, 0, 0),
                new Potion(2, "Cure2", "Heals 250 HP", 200, 250, 0, 0),
                new Potion(3, "Cure3", "Heals 2250 HP", 1000, 2250, 0, 0),
                new Potion(4, "Cure4", "Heals all HP", 2000, 9999, 0, 0),
                new Potion(5, "Ether1", "Restores 50 MP", 250, 0, 50, 0),
                new Potion(6, "Ether2", "Resotres 150 MP", 500, 0, 150, 0),
                new Armor(7, "Cap", "Light head protection", 10, 2, 1, 1),
                new Armor(8, "Robe", "Light body protection", 11, 2, 2, 1),
                new Armor(9, "Gloves", "Light hand protection", 12, 2, 3, 1),
                new Armor(10, "Hat", "Light head protection", 13, 2, 1, 1),
                new Armor(11, "Bra", "GIRLLLLLLLL", 14, 2, 2, 2)


                // Armor(int _id, string _name, string _about, int _armorValue, int _slot, int _characters)

           };


    }
}
