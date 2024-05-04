﻿using System.ComponentModel.DataAnnotations;

namespace DeleveryApp.Models
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string NumeroTelephone { get; set; }
        public string Email { get; set; }
    }

}
