using Microsoft.EntityFrameworkCore;
using Moq;
using TaskManager.Data;
using TaskManager.Models;
using TaskManager.Services.Project;

namespace TaskManager.Test
{
    public class ProjectServiceTest
    {
        [Fact]
        public void GetProjectById_ReturnsProject()
        {
            // Arrange
            var projects = new List<Project>
            {
                new Project { Id = 1, Title = "Project 1" },
                new Project { Id = 2, Title = "Project 2" },
            };

            var mockSet = MoqHelpers.CreateDbSetMock(projects);
            var mockDbContext = new Mock<IApplicationDbContext>();
            mockDbContext.Setup(c => c.Projects).Returns(mockSet.Object);

            var projectService = new ProjectService(mockDbContext.Object);

            // Act
            var project = projectService.FindProjectById(1);
            // Assert
            Assert.NotNull(project);
            Assert.Equal(1, project.Id);
        }

        [Fact]
        public void GetProjects_ReturnsListOfProjects()
        {
            // Arrange
            var projects = new List<Project>
            {
                new Project { Id = 1, Title = "Project 1" },
                new Project { Id = 2, Title = "Project 2" },
            };

            var mockSet = MoqHelpers.CreateDbSetMock(projects);
            var mockDbContext = new Mock<IApplicationDbContext>();
            mockDbContext.Setup(c => c.Projects).Returns(mockSet.Object);

            var projectService = new ProjectService(mockDbContext.Object);

            // Act
            var result = projectService.GetProjects();

            // Assert
            Assert.NotEmpty(result);
            Assert.Equal(2, result.ToList().Count);
        }
    }
}