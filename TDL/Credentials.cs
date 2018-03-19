using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace TDL
{
    class Credentials:Interface
    {
        string user1 = "Admin";
        string pass1 = "123";

        public void login(string user, string pass)
        {
            if (user == user1 && pass == pass1)
            {
                Dashboard d = new Dashboard();
                Form1 f1 = new Form1();
                f1.Hide();
                d.Show();
            }
            else
            {
                Console.WriteLine("Login FAILED!");
            }
        }
    }
}
