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
    public partial class CharacterForm : Form
    {
        Character c;
     
        public CharacterForm(Character _c)
        {
            c = _c;
            InitializeComponent();
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = c.name;
            bodyLabel.Text = c.body.Name;
            armsLabel.Text = c.arms.Name;
            helmLabel.Text = c.helm.Name;
        }

        private void findHelmButton_Click(object sender, EventArgs e)
        {
            List<Item> armorList = new List<Item>();
            armorList = Inventory.FindEquipable(1, c.charSlot);
            armorBox.DataSource = null;
            armorBox.DataSource = armorList;
            armorBox.DisplayMember = "name";

            //testing 
            //foreach(int i in armorList)
            //{
            //    Console.WriteLine(i);
            //}
        }

        private void equipButton_Click(object sender, EventArgs e)
        {
            Armor temp = (Armor)armorBox.SelectedItem;
            c.EquipArmor(temp);
            Inventory.RemoveItem(Inventory.FindIndex(temp));

            bodyLabel.Text = c.body.Name;
            armsLabel.Text = c.arms.Name;
            helmLabel.Text = c.helm.Name;

        }

        private void findBodyButton_Click(object sender, EventArgs e)
        {
            List<Item> armorList = new List<Item>();
            armorList = Inventory.FindEquipable(2, c.charSlot);
            armorBox.DataSource = null;
            armorBox.DataSource = armorList;
            armorBox.DisplayMember = "name";

        }

        private void findArmButton_Click(object sender, EventArgs e)
        {
            List<Item> armorList = new List<Item>();
            armorList = Inventory.FindEquipable(3, c.charSlot);
            armorBox.DataSource = null;
            armorBox.DataSource = armorList;
            armorBox.DisplayMember = "name";
        }

        private void findRingButton_Click(object sender, EventArgs e)
        {
            List<Item> armorList = new List<Item>();
            armorList = Inventory.FindEquipable(4, c.charSlot);
            armorBox.DataSource = null;
            armorBox.DataSource = armorList;
            armorBox.DisplayMember = "name";
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
