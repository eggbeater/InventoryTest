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
           // currentItemsBox.DataSource = new BindingSource(Inventory.d, null);
           // currentItemsBox.DisplayMember = "Value";
           // currentItemsBox.ValueMember = "Key";



        }

      

        private void addButton_Click(object sender, EventArgs e)
        {;
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
    }
}
