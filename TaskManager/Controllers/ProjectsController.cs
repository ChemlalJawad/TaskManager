using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Services.Project;

namespace TaskManager.Controllers
{
    //[Authorize]
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public  IActionResult GetAllProjects()
        {
            var projects = _projectService.GetProjects();

            return Ok(projects);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult FindProjectById([FromRoute] int Id)
        {
            var project = _projectService.FindProjectById(Id);
            return Ok(project);
        }
    }
}
