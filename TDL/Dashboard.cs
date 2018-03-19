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
        public Dashboard()
        {
            InitializeComponent();
        } 
        
        contactClass c = new contactClass(); 
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            c.Title = Title.Text;
            c.Description = Description.Text;
            c.Label = Label.Text; 

            //Inserting Data into Database
            bool success = c.Insert(c);
            if (success == true)
            {
                //Successfully Inserted
                MessageBox.Show("New Task Successfully Inserted");
                //Call the Clear Method Here
                //Clear();
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to add New task. Try Again.");
            }
            //Load Data on Data Gridview
            DataTable dt = c.Select();
           // dgvContactList.DataSource = dt;
        }
    }
}
