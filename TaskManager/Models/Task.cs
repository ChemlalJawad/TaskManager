using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; } // Clé primaire de la tâche

        [Required]
        [MaxLength(100)]
        public string? Title { get; set; } // Titre de la tâche

        [MaxLength(500)]
        public string? Description { get; set; } // Description de la tâche

        public DateTime DueDate { get; set; } // Date d'échéance de la tâche

        public bool IsCompleted { get; set; } // Indique si la tâche est terminée

        public int ProjectId { get; set; } // Clé étrangère pour lier la tâche à un projet
        public Project? Project { get; set; } // Propriété de navigation vers le projet associé

        public int CreatorId { get; set; } // Clé étrangère pour lier la tâche à un utilisateur (créateur)
        public User? Creator { get; set; } // Propriété de navigation vers l'utilisateur créateur

    }
}
