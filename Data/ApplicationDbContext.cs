using Microsoft.EntityFrameworkCore;
using System_zarządzania_błędami.Models;

namespace System_zarządzania_błędami.Data;

    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }

        public DbSet<category> Categories { get; set; }
    }

