using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StalinGames.DAL.Models;

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
            //} gaf errors

            //ShopItemsView, ShopItemsViewModel, shop toont u een lijst van backgrounds zoals employees, en een lijst van titles.
            //card toont een buy optie (of een vinkje als de player het al heeft gekocht.)
            //als je het koopt krijgt ge zo ne smooth popup van congratulations blabla en dan refresht de site na 4 seconde ofzo
        }
    }
}