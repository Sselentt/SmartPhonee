using Microsoft.EntityFrameworkCore;
using SmartPhonee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Persistance.Context
{
    public class SmartPhoneeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GB1SNRD\\SQLEXPRESS; initial Catalog=SmartPhoneeDb; integrated Security=true; TrustServerCertificate=true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Image)
                .WithOne(i => i.Product)
                .HasForeignKey<Image>(i => i.ProductID); // Image tablosunda yabancı anahtar olarak ProductID'yi belirledik

            base.OnModelCreating(modelBuilder);
        }
    }
}
