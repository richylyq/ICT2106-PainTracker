using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Diary
    {
        public int diaryID { get; set; }

        public Boolean diaryPermission { get; set; }

        public List<Entry> entries { get; set; }
    }
}
