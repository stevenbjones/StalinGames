using StalinGames.DAL.Models;
using System.Collections.Generic;

namespace StalinGames.DAL.Repositories
{
    public interface IPlayerPurchasesRepository
    {
        IEnumerable<PlayerPurchase> GetAll();

        PlayerPurchase Add(ApplicationUser user, PlayerItem item);

        IEnumerable<PlayerPurchase> GetPlayerPurchasesByUser(ApplicationUser user);
    }
}