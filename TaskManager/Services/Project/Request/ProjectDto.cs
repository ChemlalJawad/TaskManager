using TaskManager.Services.Task.Dto;

namespace TaskManager.Services.Project.Request
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<TaskDto> Tasks { get; set; }
    }
}
