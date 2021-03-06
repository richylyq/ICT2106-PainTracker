﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models
{
    public class Log
    {
        public int logID { get; set; }

        [DataType(DataType.Date)]
        public DateTime logTime { get; set; }

        public String writtenNotes { get; set; }

        public String audioNotes { get; set; }

        public String mood { get; set; }
    }
}
