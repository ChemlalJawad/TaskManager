using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set;}
        public DbSet<Project> Projects { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Task>()
              .HasOne(t => t.Project) // Une tâche est associée à un projet
              .WithMany(p => p.Tasks) // Un projet peut contenir plusieurs tâches
              .HasForeignKey(t => t.ProjectId);

            modelBuilder.Entity<Models.Task>()
               .HasOne(t => t.Creator) // Une tâche a un créateur (utilisateur)
               .WithMany(u => u.CreatedTasks) // Un utilisateur peut créer plusieurs tâches
               .HasForeignKey(t => t.CreatorId)
               .OnDelete(DeleteBehavior.NoAction); ;

            SeedData.Initialize(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

    }
}
