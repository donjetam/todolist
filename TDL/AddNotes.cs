using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDL
{
    class AddNotes:Interface_Add
    {
        //Getter Setter Properties 
        //Acts as Data Carrier in Our Application
        public string Title { get; set; }
        public string Description { get; set; }
        public string Label { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //SElecting Data from Database
        public DataTable Select()
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
        
        //Inserting DAta into Database
        internal bool Insert(Resources.contactClass c)
        {  
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //STep 1: Connect DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //STep 2: Create a SQL Query to insert DAta
                string sql = "INSERT INTO tblAdd (Title, Description, Label) VALUES (@Title, @Description, @Label)";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@Title", c.Title);
                cmd.Parameters.AddWithValue("@Description", c.Description);
                cmd.Parameters.AddWithValue("@Label", c.Label);

                //Connection Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                   isSuccess = true; 
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        public void notification_success()
        {
            MessageBox.Show("NOTES ADDED SUCCESFULLY");
        }

        public void notification_failed()
        {
            MessageBox.Show("FAILED TO SAVE NOTES");
        }
    }
}
