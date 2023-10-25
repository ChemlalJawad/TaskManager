using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.Serialization;
using TaskManager.Data;
using TaskManager.Models;
using TaskManager.Services.Project.Request;

namespace TaskManager.Services.Project
{
    public class ProjectService : IProjectService
    {
        private readonly ApplicationDbContext _context;

        public ProjectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Project FindProjectById(int id)
        {
            var project = _context.Projects
                .Include(u => u.User)
                .Include(t => t.Tasks)
                .SingleOrDefault(e => e.Id == id);

            if (project == null)
            {
                throw new EntityNotFoundException("Le projet n'a pas été trouvé."); // EntityNotFoundException est une exception personnalisée que vous pouvez créer
            }

            return project;
        }

        public IEnumerable<Models.Project> GetProjects()
        {
            var projects = _context.Projects
                .Include(u => u.User)
                .Include(t => t.Tasks)
                .ToList();

            return projects ?? new List<Models.Project>();
        }
    }

   
}
