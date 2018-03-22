using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDL
{
    public partial class Form1 : Form,Interface
    {
        Credentials c = new Credentials();
         
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            c.login(tf_username.Text, tf_password.Text);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
  
        public void login(string user, string pass)
        {
            user = tf_username.Text;
            pass = tf_password.Text;

            Console.WriteLine(user + pass);
        }
}
}
