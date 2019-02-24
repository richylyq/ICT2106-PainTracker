using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Area
    {

        public int AreaID { get; set; }
        public int EntryID { get; set; }
        public virtual Entry Entry { get; set; }
        public string Test { get; set; }
    }
}
