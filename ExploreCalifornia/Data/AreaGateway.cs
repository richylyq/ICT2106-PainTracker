﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;

namespace ExploreCalifornia.Data
{
    public class AreaGateway : DataGateway<Area>
    {
        public AreaGateway(DiaryContext context) : base(context)
        {

        }

        public Area SelectByEntryId(int? id)
        {
            return data.SingleOrDefault(area => area.EntryID == id);
            //return data.First();            
        }
    }
}