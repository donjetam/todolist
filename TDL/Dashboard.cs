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
    public partial class Dashboard : Form 
    {
        contactClass c = new contactClass();
        AddNotes ad = new AddNotes();
        VIew vv = new VIew();
      

        public Dashboard()
        {
            InitializeComponent();
            this.CenterToScreen(); 
        } 
        
        
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            vv.Show();
            vv.Select();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update d = new Update();
            d.Show(); 
            d.Selectt();
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            this.Hide();
            d.Show();
        }


        private void userShow_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        } 
    }
}
