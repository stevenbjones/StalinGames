using StalinGames.DAL.Models;

namespace StalinGames.ViewModels
{
    public class PlayerDetailsViewModel
    {
        public ApplicationUser Player { get; set; }
        public string BackgroundPath { get; set; }
    }
}