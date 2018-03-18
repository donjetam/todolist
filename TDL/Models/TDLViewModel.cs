using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDL.Models
{
    public class TDLViewModel
    {
        public int tid { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> id { get; set; }

        public string dname { get; set; }
    }
}