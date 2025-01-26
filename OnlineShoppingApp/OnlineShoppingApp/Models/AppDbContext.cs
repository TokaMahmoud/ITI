using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineShoppingApp.Models
{
    internal class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get;    set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Notification> notifications { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=OnlineShoppingApp;Trusted_Connection=True;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Buyer)
                .WithMany()
                .HasForeignKey(o => o.BuyerId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Seller)
                .WithMany()
                .HasForeignKey(o => o.SellerId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete
        }



    }
}
