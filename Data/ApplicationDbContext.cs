using DeleveryApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeleveryApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Commande> Commande { get; set; }
        public DbSet<Livreur> Livreur { get; set; }
        public DbSet<Food> Food { get; set; }





    }
}
