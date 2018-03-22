using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDL
{
    class UpdateClass:AbstractClass
    {
        public override void updateSuccess()
        {
            MessageBox.Show("Data successfully updated.");
        }

        public override void updateFail()
        {
            MessageBox.Show("Faild to update data.");
        }
    }
}
