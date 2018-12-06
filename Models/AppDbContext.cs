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
        public DbSet<Team> Team { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<TeamMembers> TeamMembers { get; set; }
        public DbSet<ClientOrganization> ClientOrganization { get; set; }
        public DbSet<ProjectDetails> ProjectDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMembers>()
                .HasKey(st => new { st.TeamID, st.StudentID });
            modelBuilder.Entity<ClientOrganization>()
                .HasKey(co => new { co.ClientID, co.OrganizationID });
            modelBuilder.Entity<ProjectDetails>()
                .HasKey(co => new { co.ClientID, co.TeamID, co.ProjectID });
        }
    }

}