using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDL
{
    public abstract class notesAbstract:Interface_Add
    {
        public abstract void notifyS();

        public abstract void notifyF();

        public void notification_success()
        {
                MessageBox.Show("Success");
        }

        public void notification_failed()
        {
            MessageBox.Show("Failed");
        }
    }
}
