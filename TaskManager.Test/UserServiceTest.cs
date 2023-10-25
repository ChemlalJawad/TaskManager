using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Data;
using TaskManager.Models;
using TaskManager.Services.User;
using TaskManager.Services.User.Request;

namespace TaskManager.Test
{
    public class UserServiceTest
    {
        [Fact]
        public void GetUserById_ReturnsUser()
        {
            // Arrange
            var users = new List<User>
        {
            new User { Id = 1, FirstName = "user1", LastName = "lastname1" },
            new User { Id = 2, FirstName = "user2" , LastName = "lastname2" },
        };

            var mockSet = MoqHelpers.CreateDbSetMock(users);
            var mockDbContext = new Mock<IApplicationDbContext>();
            mockDbContext.Setup(c => c.Users).Returns(mockSet.Object);

            var userService = new UserService(mockDbContext.Object);

            // Act
            var user = userService.FindUserById(1);

            // Assert
            Assert.NotNull(user);
            Assert.Equal(1, user.Id);
        }

        [Fact]
        public void GetUsers_ReturnsListOfUsers()
        {
            // Arrange
            var users = new List<User>
        {
            new User { Id = 1, FirstName = "user1", LastName = "lastname1" },
            new User { Id = 2, FirstName = "user2" , LastName = "lastname2" },
        };

            var mockSet = MoqHelpers.CreateDbSetMock(users);
            var mockDbContext = new Mock<IApplicationDbContext>();
            mockDbContext.Setup(c => c.Users).Returns(mockSet.Object);

            var userService = new UserService(mockDbContext.Object);

            // Act
            var result = userService.GetAllUsers();

            // Assert
            Assert.NotEmpty(result);
            Assert.Equal(2, result.ToList().Count);
        }

        [Fact]
        public void AddUser_ReturnsAddedUser()
        {
            // Arrange
            var newUser = new CreateUser { FirstName = "Jawad", LastName = "Chemlal", Email = "Jawad@chemall.com" , PhoneNumber = "0494949186", Password = "123" };
            var mockSet = MoqHelpers.CreateDbSetMock(new List<User>());
            var mockDbContext = new Mock<IApplicationDbContext>();
            mockDbContext.Setup(c => c.Users).Returns(mockSet.Object);

            var userService = new UserService(mockDbContext.Object);

            // Act
            var addedUser = userService.AddUser(newUser);

            // Assert
            Assert.NotNull(addedUser);
            Assert.Equal(newUser.Email, addedUser.Email);
            Assert.Equal(newUser.FirstName, addedUser.FirstName);
        }

        [Fact]
        public void AddUser_SavesToDatabase()
        {
            // Arrange
            var newUser = new CreateUser { FirstName = "Jawad", LastName = "Chemlal", Email = "Jawad@chemall.com", PhoneNumber = "0494949186", Password = "123" };
            var users = new List<User>();
            var mockSet = MoqHelpers.CreateDbSetMock(users);
            var mockDbContext = new Mock<IApplicationDbContext>();
            mockDbContext.Setup(c => c.Users).Returns(mockSet.Object);

            var userService = new UserService(mockDbContext.Object);

            // Act
            var addedUser = userService.AddUser(newUser);

            // Assert
            mockSet.Verify(m => m.Add(addedUser), Times.Once);
            mockDbContext.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
