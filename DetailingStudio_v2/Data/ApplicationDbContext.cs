using DetailingStudio_v2.Enums;
using DetailingStudio_v2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DetailingStudio_v2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Affiliate> Affiliates { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<Order>()
                .Property(e => e.CarBodyType)
                .HasConversion(
                    v => v.ToString(),
                    v => (CarBodyType)Enum.Parse(typeof(CarBodyType), v));

            builder
                .Entity<Order>()
                .Property(e => e.OrderPaymentStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (OrderPaymentStatus)Enum.Parse(typeof(OrderPaymentStatus), v));

            builder
                .Entity<Order>()
                .Property(e => e.OrderStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (OrderStatus)Enum.Parse(typeof(OrderStatus), v));
        }
    }
}
