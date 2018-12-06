using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace CIDM3312Project.Models
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Data Source=AppDb.db";
                    
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }

        // protected override void OnConfiguring(
        //     DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite(ConnectionString);
        // }

        public DbSet<Member> Member { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectDetails> ProjectDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectDetails>()
                .HasKey(pd => new { pd.ClientID, pd.ProjectID });
        }
    }

}