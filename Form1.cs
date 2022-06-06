using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Milestone4Final
{
    public partial class Form1 : Form
    {
        int currentStock_Small = 8, currentStock_medium = 12, currentStock_large = 18, currentStock_x_large = 20;
        CheckBox checkBox5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CurrentInventory(checkBox1, currentStock_Small);
        }
        void CurrentInventory(CheckBox c, int c_Stock)
        {
            listBox1.Items.Clear();
            if (c.Checked == true)
                listBox1.Items.Add("Current Inventory of " + c.Text + "Stock " + c_Stock.ToString() + "/20");
            else
                listBox1.Items.Clear();
        }

        void restockbtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                currentStock_Small = 20;
                CurrentInventory(checkBox1, currentStock_Small);
            }
            else if (checkBox2.Checked == true)
            {
                currentStock_medium = 20;
                CurrentInventory(checkBox2, currentStock_medium);
            }
            else if (checkBox3.Checked == true)
            {
                currentStock_large = 20;
                CurrentInventory(checkBox3, currentStock_large);
            }
            else if (checkBox4.Checked == true)
            {
                currentStock_x_large = 20;
                CurrentInventory(checkBox4, currentStock_x_large);
            }
            else if (checkBox5.Checked == true)
            {
                int currentStock_xX_large = 20;
                CurrentInventory(checkBox5, currentStock_xX_large);
            }
            else
            {
                MessageBox.Show("Nothing is selected for Restocking");
            }
        }
       private void addBtn_Click(object sender, System.EventArgs e)
        {
            checkBox5 = new CheckBox();
            checkBox5.Text = "XX-Large Boxes";
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(102, 141 + 30);
            checkBox5.CheckedChanged += new EventHandler(checkBox5_CheckedChanged);
            this.Controls.Add(checkBox5);
        }

        void searchBtn_Click(object sender, System.EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Small Boxes  " +
                    "Medium Boxes  " +
                    "Large Boxes  " +
                    "X-Large Boxes  " +
                    "XX-Large Boxes");
                return;
            }


            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("You are Currently Stocked!");
                return;
            }
        }
        private void displayBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string selectedItem = string.Empty;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    selectedItem += Convert.ToString(listBox1.Items[i]) + Environment.NewLine;

                }
                MessageBox.Show(selectedItem);
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CurrentInventory(checkBox2, currentStock_medium);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CurrentInventory(checkBox3, currentStock_large);
        }
        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            CurrentInventory(checkBox4, currentStock_x_large);
        }

        private void restockBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CurrentInventory(checkBox4, currentStock_x_large);
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                CurrentInventory(((CheckBox)sender), 20);
            }
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}