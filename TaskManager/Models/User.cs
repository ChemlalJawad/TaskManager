using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(256)]
        public string Email { get; set; }

        [Required]
        [MinLength(6)] // Exemple de contrainte de longueur minimale pour le mot de passe
        public string Password { get; set; }

        [Phone]
        [MaxLength(15)] // Exemple de contrainte de longueur maximale pour le numéro de téléphone
        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; } // Date d'inscription de l'utilisateur

        // Relations avec d'autres entités, par exemple, les projets auxquels l'utilisateur est associé
        public ICollection<Project> Projects { get; set; }
    }
}
