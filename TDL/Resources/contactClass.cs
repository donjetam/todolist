using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Data;
using System.Data.SqlClient;   

namespace TDL.Resources
{
    class contactClass
    {
        //Getter Setter Properties 
        //Acts as Data Carrier in Our Application
        public int ID {get; set; }
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
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Method to update data in database from our application
        public bool Update(contactClass c)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to update data in our Database
                string sql = "UPDATE tblAdd SET Title=@Title, Description=@Description, Label=@Label WHERE ID=@ID";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add value 
                cmd.Parameters.AddWithValue("@ID", c.ID);
                cmd.Parameters.AddWithValue("@Title", c.Title);
                cmd.Parameters.AddWithValue("@Description", c.Description);
                cmd.Parameters.AddWithValue("@Label", c.Label); 
                //Open DAtabase Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs sucessfully then the value of rows will be greater than zero else its value will be zero
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
        //Method to Delete Data from database
        public bool Delete(contactClass c)
        {
            //Create a default return value and set its value to false
            bool isSuccess = false;
            //Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL delete data
                string sql = "DELETE FROM tblAdd WHERE ID=@ID";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", c.ID);
                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query run sucessfully then the value of rows is greater than zero else its value is 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}


////Inserting DAta into Database
//public bool Insert(contactClass c)
//{
//    //Creating a default return type and setting its value to false
//    bool isSuccess = false;

//    //STep 1: Connect DAtabase
//    SqlConnection conn = new SqlConnection(myconnstrng);
//    try
//    {
//        //STep 2: Create a SQL Query to insert DAta
//        string sql = "INSERT INTO tblAdd (Title, Description, Label) VALUES (@Title, @Description, @Label)";
//        //Creating SQL Command using sql and conn
//        SqlCommand cmd = new SqlCommand(sql, conn);
//        //Create Parameters to add data
//        cmd.Parameters.AddWithValue("@Title", c.Title);
//        cmd.Parameters.AddWithValue("@Description", c.Description);
//        cmd.Parameters.AddWithValue("@Label", c.Label); 

//        //Connection Open Here
//        conn.Open();
//        int rows = cmd.ExecuteNonQuery();
//        //If the query runs successfully then the value of rows will be greater than zero else its value will be 0
//        if (rows > 0)
//        {
//            isSuccess = true;
//        }
//        else
//        {
//            isSuccess = false;
//        }
//    }
//    catch (System.Data.SqlClient.SqlException sqlException)
//    {
//        System.Windows.Forms.MessageBox.Show(sqlException.Message);
//    }
//    finally
//    {
//        conn.Close();
//    }
//    return isSuccess;
//}
