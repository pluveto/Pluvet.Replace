using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pluvet.Replace
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnFromAdd_Click(object sender, EventArgs e)
        {
            lbFrom.Items.Add(tbFrom.Text);
            tbFrom.Clear();
        }

        private void BtnToAdd_Click(object sender, EventArgs e)
        {
            lbTo.Items.Add(tbTo.Text);
            tbTo.Clear();
        }

        private void BtnDo_Click(object sender, EventArgs e)
        {
            if(lbFrom.Items.Count!=lbTo.Items.Count)
            {
                MessageBox.Show("查找-替换对 数量不匹配");
                return;
            }
            tbContent.Text = Domain.Replacer.Do(tbContent.Text, lbFrom.Items.Cast<string>(), lbTo.Items.Cast<string>());
            
        }

        private void BtnFromUp_Click(object sender, EventArgs e)
        {
            MoveItem(lbFrom, 1);
        }
        public void MoveItem(ListBox lb ,int direction)
        {
            // Checking selected item
            if (lb.SelectedItem == null || lb.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lb.SelectedIndex - direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lb.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lb.SelectedItem;

            // Removing removable element
            lb.Items.Remove(selected);
            // Insert it in new position
            lb.Items.Insert(newIndex, selected);
            // Restore selection
            lb.SetSelected(newIndex, true);
        }

        private void BtnFromDown_Click(object sender, EventArgs e)
        {
            MoveItem(lbFrom, -1);
        }

        private void BtnToUp_Click(object sender, EventArgs e)
        {
            MoveItem(lbTo, 1);
        }

        private void BtnToDown_Click(object sender, EventArgs e)
        {
            MoveItem(lbTo, -1);
        }

        private void BtnFromDel_Click(object sender, EventArgs e)
        {
            removeSelect(lbFrom);
        }
        private void removeSelect(ListBox lb)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lb);
            selectedItems = lb.SelectedItems;

            if (lb.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lb.Items.Remove(selectedItems[i]);
            }
        }

        private void BtnToDel_Click(object sender, EventArgs e)
        {
            removeSelect(lbTo);
        }

        private void TbContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
