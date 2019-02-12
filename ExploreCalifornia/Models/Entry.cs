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

        public int diaryID { get; set; }

        public String entryTitle { get; set; }

        public String entryDescription { get; set; }

        //public List<PainArea> painArea { get; set; } not sure bout this list part

        //public List<PainIntensity> painIntensity { get; set; }

        [DataType(DataType.Date)]
        public DateTime painTime { get; set; }

        
        
        //[DataType(DataType.Date)]
        //public DateTime creationDate { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime logDateTime { get; set; }

        //public List<Log> logs { get; set; }

        //public String logNotes { get; set; }

        //public String logType { get; set; }
    }
}
