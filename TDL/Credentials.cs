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
        string user1 = "user";
        string pass1 = "123";

        enum Users
        {
            Egzona,
            Donjeta,
            Vjosa,
        };

        public void login(string user, string pass)
        {
            if (user == user1 && pass == pass1)
            {
                Users users = Users.Donjeta;
                if (users == Users.Egzona)
                {
                    MessageBox.Show("Egzona is logged in");
                }
                else if (users == Users.Donjeta)
                {
                    MessageBox.Show("Donjeta is logged in");
                }
                else
                {
                    MessageBox.Show("Vjosa is logged in");
                }

                Dashboard d = new Dashboard();
                Form1 f1 = new Form1();
                f1.Hide();
                d.Show();
            }
            else
            { 
                MessageBox.Show("Login FAILED! Wrong Credencial. Check again!");
                Form1 f1 = new Form1();
                f1.Show();

            }
        }
         
    }
}
