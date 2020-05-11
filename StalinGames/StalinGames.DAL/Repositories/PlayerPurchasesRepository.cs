using Microsoft.EntityFrameworkCore;
using StalinGames.DAL.Context;
using StalinGames.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StalinGames.DAL.Repositories
{
    public class PlayerPurchasesRepository : IPlayerPurchasesRepository
    {
        private readonly AppDbContext _context;

        public PlayerPurchasesRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PlayerPurchase> GetAll()
        {
            return _context.PlayerPurchases;
        }

        public IEnumerable<PlayerPurchase> GetPlayerPurchasesByUser(ApplicationUser user)
        {
            List<PlayerPurchase> playerPurchases = _context.PlayerPurchases.ToList();
            List<PlayerPurchase> playerPurchasesByUser = new List<PlayerPurchase>();
            for (int i = 0; i < playerPurchases.Count(); i++)
            {
                if (playerPurchases[i].UserID == user.Id)
                {
                    playerPurchasesByUser.Add(playerPurchases[i]);
                }
            }
            return playerPurchasesByUser;
        }

        public PlayerPurchase Add(ApplicationUser user, PlayerItem item)
        {
            var newPlayerPurchase = _context.PlayerPurchases.Add(new PlayerPurchase
            {
                OrderID = Guid.NewGuid().ToString(),
                UserID = user.Id,
                ItemID = item.ItemID
            });

            if (newPlayerPurchase != null && newPlayerPurchase.State == EntityState.Added)
            {
                var affectedRows = _context.SaveChanges();

                if (affectedRows > 0)
                {
                    return newPlayerPurchase.Entity;
                }
            }

            return null;
        }
    }
}