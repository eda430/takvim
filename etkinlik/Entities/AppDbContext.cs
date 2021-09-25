using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etkinlik.Entities
{
    public class AppDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-URCH9U0J; Database=dbTakvim; Integrated Security=true");
        }

        public DbSet<Event> Events { get; set; }
    }
}
