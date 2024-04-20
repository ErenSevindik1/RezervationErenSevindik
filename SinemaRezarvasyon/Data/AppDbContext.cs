using Microsoft.EntityFrameworkCore;
using RezervationErenSevindik.Models;
using RezervationErenSevindik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervationErenSevindik.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=..\\..\\files\\RezervationErenSevindikDb.db");
        }

        public DbSet<Film> Film { get; set; }
        public DbSet<Seans> Seans { get; set; }
        public DbSet<Rezervasyon> Rezervasyon { get; set; }
    }
}
