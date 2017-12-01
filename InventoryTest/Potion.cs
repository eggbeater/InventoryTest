using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{
     class Potion : Item
    {
        int hp, id, mp, type, cost;
        string name, about;
        int statusRemoved;

        public Potion(int _id, string _name, string _about, int _cost, int _hp, int _mp , int _statusRemoved)
        {
            id = _id;
            name = _name;
            hp = _hp;
            mp = _mp;
            type = 1; // all potions are type 1 atm
            statusRemoved = _statusRemoved; // 0 = none, 1 = revive for the moment
            about = _about;
            cost = _cost;

        }

        public Potion() //empty potion
        {
            id = 0;
            name = "";
            type = 0;
        }

        //property accessors

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Type { get; set; }
        public string About { get => about; set => about = value; }// text that gives a quick desc of the item.
        public int Cost { get => cost; set => cost = value; }

    }
}
