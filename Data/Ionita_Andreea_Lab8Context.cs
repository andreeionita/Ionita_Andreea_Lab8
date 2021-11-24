using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ionita_Andreea_Lab8.Models;

namespace Ionita_Andreea_Lab8.Data
{
    public class Ionita_Andreea_Lab8Context : DbContext
    {
        public Ionita_Andreea_Lab8Context (DbContextOptions<Ionita_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ionita_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ionita_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ionita_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
