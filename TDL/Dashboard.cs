using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDL.Resources;


namespace TDL
{
    //declearing struct
    struct logout {
        public string logoutt;
    }
    public partial class Dashboard : Form, Switcher
    {
       //creating object of struct
        logout lo = new logout();
        contactClass c = new contactClass();
        AddNotes ad = new AddNotes();
        VIew vv = new VIew();
        Buttons buttons = new Buttons();
         
        public Dashboard()
        {
            InitializeComponent();
            this.CenterToScreen();
            ownEventHandler = new OwnEventHandler(); 
            //Adding event to event handler
            ownEventHandler.Event += ShowMessageEvent;
        }

        //Initialize event handling
        private OwnEventHandler ownEventHandler;
        //Creat event that must be raised
        private void ShowMessageEvent(object source, EventArgs args)
        {
            MessageBox.Show("This is a TODOLIST application developed by: Egzona Vjosa Donjeta!");
        } 
        private void button4_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);

            ownEventHandler.FireEvent();
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
            buttons.SwitchTo(this, sender);
        }


        private void userShow_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //calling struct
            lo.logoutt = "System is closing...";
            MessageBox.Show(lo.logoutt);
            Application.Exit();
        }
                
    }
}
