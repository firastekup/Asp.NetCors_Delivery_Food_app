using System.ComponentModel.DataAnnotations;

namespace DeleveryApp.Models
{
    public class Livreur
    {
        [Key]
        public int IdLivreur { get; set; }
        public string Nom { get; set; }
        public string Vehicule { get; set; }
        public string ZoneLivraison { get; set; }
        public bool Disponibilite { get; set; }
    }

}
