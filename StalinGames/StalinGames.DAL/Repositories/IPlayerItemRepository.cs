using StalinGames.DAL.Models;
using System.Collections.Generic;

namespace StalinGames.DAL.Repositories
{
    public interface IPlayerItemRepository
    {
        IEnumerable<PlayerItem> GetAll();

        PlayerItem FindByID(string id);

        PlayerItem FindByName(string name);
    }
}