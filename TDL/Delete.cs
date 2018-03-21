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
    public partial class Delete : Form
    {
        Dashboard d = new Dashboard();
        VIew v = new VIew();
        Update up = new Update();
        public Delete()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            d.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            v.Show();
            up.Selectt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            up.Show();
            up.Selectt();
        }
    }
}
