using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDL.Resources;

namespace TDL
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        contactClass c = new contactClass();

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        //SElecting Data from Database
        public DataTable Selectt()
        {
            ///Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM tblAdd";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dgvContactList.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
         

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.Title.Text) || string.IsNullOrWhiteSpace(this.Label.Text) || string.IsNullOrWhiteSpace(this.Description.Text))
            {
                MessageBox.Show("Please fill up the form!");
            }
            else { 
            //Get the Data from textboxes
            c.ID = int.Parse(ID.Text);
            c.Title = Title.Text;
            c.Description = Description.Text;
            c.Label = Label.Text;
            //Update Data in Database
            bool success = c.Update(c);
            if (success == true)
            {
                //Updated Successfully
                MessageBox.Show("Contact has been successfully Updated.");
                //Load Data on Data Gridview
              //  DataTable dt = c.Selectt();
               // dgvContactList.DataSource = dt;
                //Call Clear Method
                Selectt();
                Clear();
            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to Update Contact.Try Again.");
            }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

         
        public void Clear() {
            ID.Text = "";
            Title.Text = String.Empty;
            Description.Text = String.Empty;
            Label.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIew v = new VIew();
            v.Show();
            Selectt();
        }

        private void btn_add_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            this.Hide();
            d.Show();
        }
    }
}
