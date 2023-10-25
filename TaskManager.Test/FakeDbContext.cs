using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Test
{
    internal class FakeDbContext : DbContext,IApplicationDbContext
    {
        public DbSet<User> Users { get ; set; }
        public DbSet<Project> Projects { get; set ; }
        public DbSet<Models.Task> Tasks { get ; set; }
    }
}
