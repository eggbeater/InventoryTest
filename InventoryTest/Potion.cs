using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{
     class Potion : Item
    {
        int hp;
        int mp;
        int statusRemoved;

        public Potion(int _id, string _name, string _about, int _hp, int _mp , int _statusRemoved)
        {
            id = _id;
            name = _name;
            hp = _hp;
            mp = _mp;
            type = 1; // all potions are type 1 atm
            statusRemoved = _statusRemoved; // 0 = none, 1 = revive for the moment
            about = _about;

        }

    }
}
