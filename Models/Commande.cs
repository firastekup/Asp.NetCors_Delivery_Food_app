using System.ComponentModel.DataAnnotations;

namespace DeleveryApp.Models
{
    public class Commande
    {
        [Key]
        public int IdCommande { get; set; }
        public int IdClient { get; set; }
        public int? IdLivreur { get; set; }
        public DateTime DateCommande { get; set; }
        public string Statut { get; set; }
    }

}
