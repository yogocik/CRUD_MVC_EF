using System;
using WebMVCMetrodata.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebMVCMetrodata.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}