using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StalinGames.DAL.Models;
using System.Linq;

namespace StalinGames.DAL.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<PlayerPurchase> PlayerPurchases { get; set; }
        public DbSet<PlayerItem> PlayerItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            //foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            //}
            //gaf fouten + niet nodig in dit programma, we gebruiken een soft delete ->
            //gebruikers hebben een Status kolom -> Active is actief, Deleted zijn ze gedelete
        }

        
    }
}