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
            string user1 = "xona";
            string pass1 = "123";
            string user2 = "donjeta";
            string user3 = "vjosa";
            
            if(user1 == user && pass1 == pass){
                Users users = Users.Egzona;
                MessageBox.Show(users + " is logged in");
                d.Show();
            }
            else if (user2 == user && pass1 == pass)
            {
                Users users = Users.Donjeta;
                MessageBox.Show(users + " is logged in");
                d.Show();

            }
            else if (user3 == user && pass1 == pass)
            {
                Users users = Users.Vjosa;
                MessageBox.Show(users + " is logged in");
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
