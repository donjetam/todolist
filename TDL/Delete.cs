﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDL.Resources;

namespace TDL
{
    public partial class Delete : Form, Switcher
    {
        Dashboard d = new Dashboard();
        VIew v = new VIew();
        Update up = new Update();
        contactClass c = new contactClass();
        Buttons buttons = new Buttons();

        public Delete()
        {
            InitializeComponent();
            this.CenterToScreen();
            Load_Notes();
            foreach (var button in Controls.OfType<Button>())
            {
                button.Click += button_Click;
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            buttons.SwitchTo(this, sender);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //Get the Contact ID fromt Application
            c.ID = Convert.ToInt32(ID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                //Successfully Deleted
                MessageBox.Show("Notes successfully deleted.");
                //Refresh Data GridView
                //Load Data on Data GRidview
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Call the Clear Method Here
                Clear();
            }
            else
            {
                //Failed to Delete
                MessageBox.Show("Failed to Delete Dontact. Try Again.");
            }
        }
        public void Clear() {
            ID.Text = "";
            Label.Text = "";
            Description.Text = "";
        }

        private void dgvContactList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the data from data grid view and load it to the textboxes respectively
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            ID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            Title.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            Description.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            Label.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString(); 
        }
        private void Load_Notes()
        {
            //Load Data on Data Gridview
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }
    }
}