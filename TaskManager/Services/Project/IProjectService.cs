using TaskManager.Models;

namespace TaskManager.Services.Project
{
    public interface IProjectService
    {
        IEnumerable<Models.Project> GetProjects();
        Models.Project FindProjectById(int id);
    }
}
