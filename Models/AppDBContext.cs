using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace CIDM3312Project.Models
{
    public class AppDBContext : DbContext
    {
        private const string ConnectionString = @"Data Source=AppDb.db";
                    

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<FacultySponsor> FacultySponsor { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<StudentTeams> StudentTeams { get; set; }
        public DbSet<ClientOrganization> ClientOrganization { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentTeams>()
                .HasKey(st => new { st.TeamID, st.StudentID });
            modelBuilder.Entity<ClientOrganization>()
                .HasKey(co => new { co.ClientID, co.OrganizationID });
            modelBuilder.Entity<ProjectTeams>()
                .HasKey(co => new { co.TeamID, co.ProjectID});
            modelBuilder.Entity<ClientOrganization>()
                .HasKey(co => new { co.ClientID, co.OrganizationID});
        }
    }

}