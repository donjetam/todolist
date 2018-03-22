using System;
using System.Windows.Forms;

namespace TDL
{
    class Buttons
    {

        public void SwitchTo(Switcher from, object sender)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_add":
                    this.ChangeView(from, new Dashboard());
                    break;
                case "btn_view":
                    VIew v = new VIew();
                    this.ChangeView(from,v);
                    v.Select();
                    break;
                case "btn_update":
                    Update u = new Update();
                    this.ChangeView(from, u);
                    u.Selectt();
                    break;
                case "btn_delete":
                    Delete d = new Delete();
                    this.ChangeView(from, d);
                    d.Select();
                    break;
                case "btn_dashboard":
                    this.ChangeView(from, new Dashboard());
                    break;
            }
           
        }

        void ChangeView(Switcher from, Switcher to)
        {
            from.Hide();
            to.Show();
        }
    }
}
