using DetailingStudio_v2.Models;
using Microsoft.EntityFrameworkCore;

public class DetailingStudioContext : DbContext
{
    public DbSet<Affiliate> Affiliates{ get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Service> Services { get; set; }
}