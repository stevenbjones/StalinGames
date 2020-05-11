using StalinGames.DAL.Context;
using StalinGames.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace StalinGames.DAL.Repositories
{
    public class PlayerItemRepository : IPlayerItemRepository
    {
        private readonly AppDbContext _context;

        public PlayerItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PlayerItem> GetAll()
        {
            return _context.PlayerItems;
        }

        public PlayerItem FindByID(string id)
        {
            return _context.PlayerItems.Find(id);
        }

        public PlayerItem FindByName(string name)
        {
            List<PlayerItem> playerItems = _context.PlayerItems.ToList();
            for (int i = 0; i < playerItems.Count(); i++)
            {
                if (playerItems[i].Name == name)
                {
                    return playerItems[i];
                }
            }
            return null;
        }
    }
}