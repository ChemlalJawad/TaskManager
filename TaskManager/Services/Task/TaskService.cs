using Microsoft.EntityFrameworkCore;
using TaskManager.Data;

namespace TaskManager.Services.Task
{
    public class TaskService : ITaskService
    {
        private readonly IApplicationDbContext _context;
        public TaskService(IApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Task FindTaskById(int id)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                throw new EntityNotFoundException("Pas de taches trouver");
            }
            return task;
        }

        public  IEnumerable<Models.Task> GetAllTasks()
        {
            var tasks = _context.Tasks.ToList();

            return tasks;
        }
    }
}
