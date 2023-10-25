using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class Project
    {
        public int Id { get; set; } // Clé primaire du projet

        [Required]
        [MaxLength(100)]
        public string? Title { get; set; } // Titre du projet

        [MaxLength(500)]
        public string? Description { get; set; } // Description du projet

        public DateTime StartDate { get; set; } // Date de début du projet

        public DateTime EndDate { get; set; } // Date de fin du projet

        public int? UserId { get; set; } // Clé étrangère pour lier le projet à un utilisateur
        public User? User { get; set; } // Propriété de navigation vers l'utilisateur propriétaire

        public ICollection<Task>? Tasks { get; set; } // Collection de tâches associées à ce projet

        // Autres propriétés ou méthodes nécessaires
    }
}
