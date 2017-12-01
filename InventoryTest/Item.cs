using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest
{

    //changed this to an interface because im getting less dumb about programming, I hope I didnt fuck anything up in the process
    public interface Item
    {
         int Id { get; set; } // must be unique
         string Name { get; set; }
         int Type { get; set; }
         string About { get; set; }// text that gives a quick desc of the item.
         int Cost { get; set; }

       

    }

    //public class Item
    //{
    //    public int id { get; set; } // must be unique
    //    public string name { get; set; }
    //    public int type { get; set; }
    //    public string about { get; set; }// text that gives a quick desc of the item.
    //    public int cost { get; set; }

    //    public Item() // 'empty item' / the absense of an item
    //    {
    //        id = 0;
    //        name = "";
    //        type = 0;
    //        about = "";
    //        cost = 0;
    //    }

    //}
}
