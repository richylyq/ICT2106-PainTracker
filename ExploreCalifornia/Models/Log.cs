using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Log
    {
        public int logID { get; set; }

        public String type { get; set; }

        public String title { get; set; }

        public String description { get; set; }

        public int priority { get; set; }
    }
}
