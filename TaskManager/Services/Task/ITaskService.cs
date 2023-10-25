namespace TaskManager.Services.Task
{
    public interface ITaskService
    {
        IEnumerable<Models.Task> GetAllTasks();
        Models.Task FindTaskById(int id);
    }
}
