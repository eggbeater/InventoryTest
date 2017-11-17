using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{
    class InventoryItem
    {
        public Item item; //public for now while i test things
        public int count;

        public InventoryItem(Item _item, int _count)
        {

            item = _item;
            count = _count;

        }
    }
}
