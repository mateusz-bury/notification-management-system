using Microsoft.EntityFrameworkCore;
using System_zarządzania_błędami.Entities;
using System_zarządzania_błędami.Models;

namespace System_zarządzania_błędami.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=NotificationSystemDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }

    //public DbSet<Category> Categories { get; set; }
    public DbSet<Errors> Errors { get; set; }
    public DbSet<Priorities> Priorities { get; set; }
    public DbSet<Reports> Reports { get; set; }
    public DbSet<UserReports> UserReports { get; set; }
    public DbSet<Users> Users { get; set; }


}

