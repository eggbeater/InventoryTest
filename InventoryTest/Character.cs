using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* THOUGHTS
 * prolly makes sense have make a bunch of static characters than a bunch of static classes? maybe?

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
      public class Character //testing
     {
        public string name;
        int currentHp;
        int maxHp;
        int stam;
        int def;
        int attack;
        int str;

        public Armor helm;
        public Armor body;
        public Armor arms;
        public Armor ring;
        public int charSlot;

        public Character(string _name, int _charSlot) //temp constructor for testing. 
        {
            name = _name;
            charSlot = _charSlot;
            currentHp = 100;
            maxHp = 100;
            stam = 10;
            def = 10;
            attack = 1;
            str = 10;
            helm = new Armor();
            body = new Armor();
            ring = new Armor();
            arms = new Armor();
        }

      


        public void RemoveArmor(int slot) //just remove armor and put in Inventory
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

        public   void CorrectTheValues() //this could use a better name
        {
            //will later inclue things like resetting elemental affinity and attack. 
            def = stam + helm.armorValue + body.armorValue + arms.armorValue + ring.armorValue;
        }
        public   void EquipArmor(Armor armor) // pretty self explainitory
        {
            RemoveArmor(armor.slot);
            if (armor.slot == 1)
            {
                helm = armor;
            }

            else if (armor.slot == 2)
            {
                body = armor;
            }

            else if (armor.slot == 3)
            {
                arms = armor;
            }

            else if (armor.slot == 4)
            {
                ring = armor;
            }

            CorrectTheValues();

        }

        public void printEqupied()
        {
            Console.WriteLine(helm.Name);
            Console.WriteLine(body.Name);
            Console.WriteLine(arms.Name);
        }

    }

}
