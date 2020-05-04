using Microsoft.AspNetCore.Identity;

namespace StalinGames.DAL.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }

        public int Blyats { get; set; }
        public string ProfilePicturePath { get; set; }
        public string LastGamePlayed { get; set; } //Opgelet: formaat is unixtimeseconds -> yyyyMMddHHmmssffff dus je kan gewoon convertere naar int en dan vergelijke of het getal 10 miljard keer groter is
        public string BackGroundPath { get; set; }
        public ProfileTitles ProfileTitle { get; set; }
        public int TotalGamesPlayed { get; set; }
        public int TotalBlyatsLost { get; set; }

    }
}
