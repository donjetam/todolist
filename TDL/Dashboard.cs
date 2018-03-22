using System;
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
    public partial class Dashboard : Form, Switcher
    {
        public Dashboard()
        {
            InitializeComponent();
            this.CenterToScreen();
        } 
        
        contactClass c = new contactClass();
        AddNotes ad = new AddNotes();
        VIew vv = new VIew();
        Buttons buttons = new Buttons();
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.Title.Text) || string.IsNullOrWhiteSpace(this.Label.Text) || string.IsNullOrWhiteSpace(this.Description.Text))
            {
                MessageBox.Show("Please fill up the form!");
            }
            else { 
            
            //Get the value from the input fields
            c.Title = Title.Text;
            c.Description = Description.Text;
            c.Label = Label.Text; 

            //Inserting Data into Database
            bool success = ad.Insert(c);
            if (success == true)
            {
                ad.notification_success();
                //Call the Clear Method Here
                Clear();
            }
            else
            {
                //Failed to Add Contact
                ad.notification_failed();
            }
            //Load Data on Data Gridview
            //DataTable dt = c.Select();
           //dgvContactList.DataSource = dt;
         }
       }

        void Clear()
        {
            Title.Text = String.Empty; 
            Description.Text = String.Empty; 
            Label  .Text = String.Empty; 
        }

        public void button_Click(object sender, EventArgs e)
        {
            buttons.SwitchTo(this, sender);
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
