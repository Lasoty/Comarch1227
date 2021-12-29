using Bibliotekarz.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekarz.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conn = "Server=localhost;Database=BibliotekarzDb6;Trusted_Connection=True;MultipleActiveResultSets=true";
                optionsBuilder.UseSqlServer(conn);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(e => e.Author).HasMaxLength(200).IsRequired(true);
            modelBuilder.Entity<Book>().Property(e => e.PageCount).HasColumnType("bigint");
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Borrowers { get; set; }
    }
}
