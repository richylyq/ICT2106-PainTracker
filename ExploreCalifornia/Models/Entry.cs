using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models
{
    public class Entry
    {
        public int entryID { get; set; }

        public List<Log> logs { get; set; }

        [DataType(DataType.Date)]
        public DateTime creationDate { get; set; }

        public String title { get; set; }

        public String description { get; set; }

        [DataType(DataType.Date)]
        public DateTime logDateTime { get; set; }

        public String painArea { get; set; }

        public String logNotes { get; set; }

        public String logType { get; set; }
    }
}
