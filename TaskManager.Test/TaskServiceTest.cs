using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Data;
using TaskManager.Services.Task;

namespace TaskManager.Test
{
    public class TaskServiceTest
    {
        [Fact]
        public void GetTaskById_ReturnsTask()
        {
            // Arrange
            var tasks = new List<Models.Task>
        {
            new Models.Task { Id = 1, Title = "Task 1" },
            new Models.Task { Id = 2, Title = "Task 2" },
        };

            var mockSet = MoqHelpers.CreateDbSetMock(tasks);
            var mockDbContext = new Mock<IApplicationDbContext>();
            mockDbContext.Setup(c => c.Tasks).Returns(mockSet.Object);

            var taskService = new TaskService(mockDbContext.Object);

            // Act
            var task = taskService.FindTaskById(1);

            // Assert
            Assert.NotNull(task);
            Assert.Equal(1, task.Id);
        }

        [Fact]
        public void GetTasks_ReturnsListOfTasks()
        {
            // Arrange
            var tasks = new List<Models.Task>
        {
            new Models.Task { Id = 1, Title = "Task 1" },
            new Models.Task { Id = 2, Title = "Task 2" },
        };

            var mockSet = MoqHelpers.CreateDbSetMock(tasks);
            var mockDbContext = new Mock<IApplicationDbContext>();
            mockDbContext.Setup(c => c.Tasks).Returns(mockSet.Object);

            var taskService = new TaskService(mockDbContext.Object);

            // Act
            var result = taskService.GetAllTasks();

            // Assert
            Assert.NotEmpty(result);
            Assert.Equal(2, result.ToList().Count);
        }
    }
}
