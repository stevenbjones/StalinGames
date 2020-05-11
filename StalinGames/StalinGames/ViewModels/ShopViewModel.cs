using StalinGames.DAL.Models;
using System.Collections.Generic;

namespace StalinGames.ViewModels
{
    public class ShopViewModel
    {
        public List<PlayerItem> profileTitles { get; set; }
        public List<PlayerItem> Backgrounds { get; set; }

        public List<PlayerItem> ProfileTitlesPurchased { get; set; }
        public List<PlayerItem> BackgroundsPurchased { get; set; }

        public string Message { get; set; }
    }
}