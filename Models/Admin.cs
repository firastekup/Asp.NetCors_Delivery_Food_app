using System.ComponentModel.DataAnnotations;

namespace DeleveryApp.Models
{
    public class Admin
    {
        [Key]
        public int IdAdmin { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string Email { get; set; }
        public DateTime DateCreation { get; set; }
    }

}
