using System;
using System.Collections.Generic;
using System.Text;
using CashMachine.Models.DataBase;
using Microsoft.EntityFrameworkCore;

namespace CashMachine.Data.DataBase
{
    public class CardDbContext : DbContext
    {
        public DbSet<Card> Card { get; set; }
        public DbSet<Owner> Owner { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=CashMachine;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasData(DbSeeder.GenerateOwners().ToArray());
            modelBuilder.Entity<Card>().HasData(DbSeeder.GenerateCards().ToArray());
        }
    }
}
