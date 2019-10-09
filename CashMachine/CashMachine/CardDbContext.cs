using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class CardDbContext : DbContext
    {
        public DbSet<Card> Card { get; set; }
        public DbSet<Owner> Owner { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=CashMachine; Trusted_Connection=True;");
        }
    }
}
