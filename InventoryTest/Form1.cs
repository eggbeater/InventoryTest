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
    public partial class Form1 : Form
    {
        List<Item> allItems;
        Character[] party = new Character[5];
        List<object> characterList = new List<object>();
        static Character cecilTest = new Character("Cecil", 1);
        static Character rosaTest = new Character("Rosa", 2);
        CharacterForm cf;
        ShopForm sf;

       


        public Form1()
        {
            InitializeComponent();
            

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allItemsBox.DataSource = null;
            allItemsBox.DataSource = InventoryData.items;
            allItemsBox.DisplayMember = "name";
           

            currentItemsBox.DataSource = null;
            party[0] = cecilTest;
           // currentItemsBox.DataSource = new BindingSource(Inventory.d, null);
           // currentItemsBox.DisplayMember = "Value";
           // currentItemsBox.ValueMember = "Key";



        }

      

        private void addButton_Click(object sender, EventArgs e)
        {
            var test = InventoryData.items[allItemsBox.SelectedIndex];
            Inventory.AddItem(test);
            

           // currentItemsBox.DataSource = null;
           // currentItemsBox.DataSource = Inventory.testList;
           // currentItemsBox.DisplayMember = "name";

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Inventory.ListInv();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Inventory.MoveItems(0, 1);
        }

        private void testButton2_Click(object sender, EventArgs e)
        {
            Inventory.Sort();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Inventory.RemoveItem(0);
        }

        private void add256Button_Click(object sender, EventArgs e)
        {
            var test = InventoryData.items[allItemsBox.SelectedIndex];
            for (int i = 0; i < 256; i++)
            {
                Inventory.AddItem(test);
            }
        }

        private void testEquipReturn_Click(object sender, EventArgs e)
        {
            Inventory.FindEquipable(1,1);
        }

        private void equipFormButton_Click(object sender, EventArgs e)
        {
            cf = new CharacterForm(rosaTest);
            cf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cecilTest.printEqupied();
            rosaTest.printEqupied();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            Shop s = new Shop();
            sf = new ShopForm(s);
            sf.Show();

        }
    }
}
