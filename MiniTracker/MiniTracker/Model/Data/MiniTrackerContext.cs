using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTracker.Model.Data
{
    class MiniTrackerContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public MiniTrackerContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MiniTrackerDB;Trusted_Connection=True;");
        }
    }
}
