using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{
     class Armor : Item
    {
        public int armorValue;
        public int slot;

        #region slot info
        // 1 = head
        // 2 = body
        // 3 = arms
        // 4 = ring

#endregion

        public int characters; //we'll figure out equip for multiple characters later
        #region character info
        // 1 = cecil
        // 2 = kain
        // 3 = rosa
        // 4 = rydia
        // 5 = edge
#endregion

        public Armor(int _id, string _name, string _about, int _armorValue, int _slot, int _characters)
        {
            id = _id;
            name = _name;
            about = _about;
            armorValue = _armorValue;
            slot = _slot;
            characters = _characters;

        }
    }
}
