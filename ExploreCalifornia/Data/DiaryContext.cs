using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using ExploreCalifornia.Models;

namespace ExploreCalifornia.Models
{
    public class DiaryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DiaryContext;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public DiaryContext()
        {
        }

        public DiaryContext (DbContextOptions<DiaryContext> options)
            : base(options)
        {
        }


        public DbSet<Tour> Tour { get; set; }
        public new DbSet<Entry> Entry { get; set; }
        public DbSet<ExploreCalifornia.Models.Area> Area { get; set; }
    }
}
