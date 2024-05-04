using System.ComponentModel.DataAnnotations;

namespace DeleveryApp.Models
{
    public class Food
    {
        [Key]
        public int IdAliment { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public string Categorie { get; set; }
    }

}
