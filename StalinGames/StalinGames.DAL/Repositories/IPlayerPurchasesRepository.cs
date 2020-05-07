using StalinGames.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StalinGames.DAL.Repositories
{
    public interface IPlayerPurchasesRepository
    {
        IEnumerable<PlayerPurchase> GetAll();
        PlayerPurchase Add(ApplicationUser user, PlayerItem item);
    }
}
