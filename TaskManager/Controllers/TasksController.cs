using Microsoft.AspNetCore.Mvc;
using TaskManager.Services.Task;

namespace TaskManager.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult GetAllTasks()
        {
            var tasks = _taskService.GetAllTasks();

            return Ok(tasks);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult FindProjectById([FromRoute] int Id)
        {
            var task = _taskService.FindTaskById(Id);
            return Ok(task);
        }
    }
}
