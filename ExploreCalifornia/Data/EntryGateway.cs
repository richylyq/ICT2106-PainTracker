using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;

namespace ExploreCalifornia.Data
{
    public class EntryGateway : DataGateway<Entry>
    {
        public EntryGateway(DiaryContext context) : base(context)
        {

        }
    }
}
