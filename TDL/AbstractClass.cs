using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDL
{
    public abstract class AbstractClass:Interface_Update
    {
        public abstract void updateSuccess();

        public abstract void updateFail();

        public void getdata()
        {
            //geting data from database
        }
    }
}
