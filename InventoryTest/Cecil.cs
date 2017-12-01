using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* testing on how to deal with a character.  Each unique character will have its own static class
even though they will share many of the same functions which seems inefficient.

MAIN PROBLEM - removing an item when inventory is full will just delete the item currrently
*/

#region slot info
// 1 = head
// 2 = body
// 3 = arms
// 4 = ring
// 255 = empty
#endregion



namespace InventoryTest
{
    static class Cecil
    {
        static int currentHp = 100;
        static int maxHp = 100;
        static int stam = 10;
        static int def = 10;
        static public Armor helm = new Armor();
        static public Armor body = new Armor();
        static public Armor arms = new Armor();
        static public Armor ring = new Armor();
        static public int charSlot = 1;

        public static void RemoveArmor(int slot) //just remove armor and put in Inventory
        {
            if (slot == 1) //remove head
            {
                if (helm.Id == 255) // checks to see if already empty and do nothing
                    return; //this probably doesnt have to be here

                else
                {
                    Inventory.AddItem(helm); //put item back in inventory
                    helm = new Armor(); // assign the new armor
                    CorrectTheValues();
                }

            }

            else if (slot == 2) //remove body
            {
                if (body.Id == 255) // checks to see if already empty and do nothing
                    return; //this probably doesnt have to be here

                else
                {
                    Inventory.AddItem(helm); //put item back in inventory
                    body = new Armor(); // assign the new armor
                    CorrectTheValues();
                }

            }

            else if (slot == 3) //remove arms
            {
                if (arms.Id == 255) // checks to see if already empty and do nothing
                    return; //this probably doesnt have to be here

                else
                {
                    Inventory.AddItem(arms); //put item back in inventory
                    arms = new Armor(); // assign the new armor
                    CorrectTheValues();
                }

            }

            else if (slot == 4) //remove ring
            {
                if (ring.Id == 255) // checks to see if already empty and do nothing
                    return; //this probably doesnt have to be here

                else
                {
                    Inventory.AddItem(ring); //put item back in inventory
                    ring = new Armor(); // assign the new armor
                    CorrectTheValues();
                }

            }
        }

        public static void CorrectTheValues() //this could use a better name
        {
            //will later inclue things like resetting elemental affinity and attack. 
            def = stam + helm.armorValue + body.armorValue + arms.armorValue + ring.armorValue;
        }
        public static void EquipArmor(Armor armor, int slot) // pretty self explainitory
        {
            RemoveArmor(slot);
            if (slot == 1)
            {
                helm = armor;
            }

            else if (slot == 2)
            {
                body = armor;
            }

            else if (slot == 3)
            {
                arms = armor;
            }

            else if (slot == 4)
            {
                ring = armor;
            }

            CorrectTheValues();

        }

    }

}
