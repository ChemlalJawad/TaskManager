using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Data
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<Models.Task> Tasks { get; set; }
        int SaveChanges();
    }
}
