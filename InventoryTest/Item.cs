using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{
    public class Item
    {
        public int id { get; set; } // must be unique
        public string name { get; set; }
        public int type { get; set; }
        public string about { get; set; }// text that gives a quick desc of the item.

        public Item() // 'empty item' / the absense of an item
        {
            id = 0;
            name = "";
            type = 0;
            about = "";
        }

    }
}
