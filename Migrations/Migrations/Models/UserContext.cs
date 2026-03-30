using Microsoft.EntityFrameworkCore;
using System;

namespace Migrations.Models
{
    public class UserContext:DbContext   
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // If it's not configured by Program.cs, use this default connection string:
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=TechFixDB;Username=postgres;Password=YourSuperSecretPassword!");
        //    }
        //}

    }
}
