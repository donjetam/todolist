using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace TDL
{
    class Credentials:Interface
    {
        Dashboard d = new Dashboard();
        
        enum Users
        {
            Egzona,
            Donjeta,
            Vjosa,
        };

        public void login(string user, string pass)
        {
            string password = "123";

            if (user == Users.Egzona.ToString() && pass == password)
            {
                MessageBox.Show(Users.Egzona + " is logged in");
                d.Show();
            }
            else if (user == Users.Donjeta.ToString() && pass == password)
            {
                MessageBox.Show(Users.Donjeta + " is logged in");
                d.Show();
            }
            else if (user == Users.Vjosa.ToString() && pass == password)
            {
                MessageBox.Show(Users.Vjosa + " is logged in");
                d.Show();

            }
            else{
                MessageBox.Show("Wrong Username/password");
                Form1 f1 = new Form1();
                f1.Show();
            }
        }
         
    }
}
