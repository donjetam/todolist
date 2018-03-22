using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDL
{
    public class Notify:notesAbstract
    {
        public override void notifyS()
        {
            MessageBox.Show("Notes successfully deleted. Abstract");
        }

        public override void notifyF()
        {
            MessageBox.Show("Notes failed to deleted.");
        }
    }
}
