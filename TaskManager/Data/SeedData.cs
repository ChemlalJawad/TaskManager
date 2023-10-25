using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

public static class SeedData
{
    public static void Initialize(ModelBuilder modelBuilder)
    {
        var users = new List<User>
        {
            new User { Id = -1, FirstName = "John", LastName = "Doe", Email = "john@example.com", Password = "password", PhoneNumber = "123-456-7890" },
            new User { Id = -2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", Password = "password", PhoneNumber = "987-654-3210" },
            // Ajoutez d'autres utilisateurs fictifs avec des ID négatifs et des numéros de téléphone
        };


        modelBuilder.Entity<User>().HasData(users);

        var projects = new List<Project>
        {
            new Project { Id = -1, Title = "Project 1", Description = "Description du projet 1", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), UserId = -1 },
            new Project { Id = -2, Title = "Project 2", Description = "Description du projet 2", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(2), UserId = -2 },
            // Ajoutez d'autres projets fictifs avec des ID négatifs
        };

        modelBuilder.Entity<Project>().HasData(projects);

        var tasks = new List<TaskManager.Models.Task>
        {
            new TaskManager.Models.Task { Id = -1, Title = "Tâche 1", Description = "Description de la tâche 1", DueDate = DateTime.Now.AddMonths(1), IsCompleted = false, ProjectId = -1, CreatorId = -1 },
            new TaskManager.Models.Task { Id = -2, Title = "Tâche 2", Description = "Description de la tâche 2", DueDate = DateTime.Now.AddMonths(1), IsCompleted = false, ProjectId = -1, CreatorId = -2 },
            // Ajoutez d'autres tâches fictives avec des ID négatifs
        };

        modelBuilder.Entity<TaskManager.Models.Task>().HasData(tasks);
    }
}
