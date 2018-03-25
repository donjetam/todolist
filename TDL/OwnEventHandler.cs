using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDL
{
    class OwnEventHandler
    {
        //Create event hanlder
        public event EventHandler<EventArgs> Event = delegate { };

        //This method raises the event
        public void FireEvent()
        {
            Event(this, EventArgs.Empty);
        }
    }
}
