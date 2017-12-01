using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTest
{
    public partial class ShopForm : Form
    {
        Shop s;
        public ShopForm(Shop _s)
        {
            s = _s;
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            gilLabel.Text = "Gil: " + Inventory.gil;

            shopBox.DataSource = null;
            shopBox.DataSource = s.shopList;
            shopBox.DisplayMember = "name";

            costBox.DataSource = null;
            costBox.DataSource = s.shopList;
            costBox.DisplayMember = "cost";

            List<Item> invList = new List<Item>();
            invList = Inventory.getItemList();

            invBox.DataSource = null;
            invBox.DataSource = invList;
            invBox.DisplayMember = "name";
            
         
        }

        private void gilLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int amount = Int32.Parse(amountBox.Text);
                Item temp = (Item)shopBox.SelectedItem;
                s.buyItem(temp, amount);

                shopBox.DataSource = null;
                shopBox.DataSource = s.shopList;
                shopBox.DisplayMember = "name";

                costBox.DataSource = null;
                costBox.DataSource = s.shopList;
                costBox.DisplayMember = "cost";

                List<Item> invList = new List<Item>();
                invList = Inventory.getItemList();

                invBox.DataSource = null;
                invBox.DataSource = invList;
                invBox.DisplayMember = "name";

                gilLabel.Text = "Gil: " + Inventory.gil; 





                //amount = Math.Abs(amount);
                //Item temp = (Item)shopBox.SelectedItem;
                //if((amount * temp.cost) > Inventory.gil)
                //{
                //    Console.WriteLine("not enough money");
                //}

                //else
                //{
                //    for(int i = 0; i < amount; i++)
                //    {
                //        Inventory.AddItem(temp);

                //    }

                //}

            }
            catch (Exception ex) { Console.WriteLine("not a number"); }

            

        }
    }
}
