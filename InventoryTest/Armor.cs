using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{
    public class Armor : Item
    {
        public int armorValue;
        public int slot;
        int id, cost;
        string about, name;

        #region slot info
        // 1 = head
        // 2 = body
        // 3 = arms
        // 4 = ring
        // 255 = empty

        #endregion

        public int characters; //we'll figure out equip for multiple characters later
        #region character info
        // 0 = Everyone
        // 1 = cecil
        // 2 = kain
        // 3 = rosa
        // 4 = rydia
        // 5 = edge
        #endregion

        public Armor(int _id, string _name, string _about, int _cost, int _armorValue, int _slot, int _characters)
        {
            id = _id;
            name = _name;
            about = _about;
            armorValue = _armorValue;
            slot = _slot;
            characters = _characters;
            cost = _cost;

        }
        public Armor() //no amror to wear with nothing on
        {
            id = 255;
            name = "";
            about = "";
            armorValue = 0;
            slot = 255; //this is the only thing that is a '5'
            characters = 0; //everyone
            cost = 0;


        }

        //property accessors

        public int Id  { get => id; set => id = value; } 
        public string Name   {   get => name; set => name = value; }
        public int Type { get ; set; }
        public string About { get => about; set => about = value; }// text that gives a quick desc of the item.
        public int Cost { get => cost; set => cost = value; }

    }
}
