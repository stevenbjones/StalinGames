using Microsoft.AspNetCore.Identity;
using System;

namespace StalinGames.DAL.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Blyats { get; set; }
        public string ProfilePicturePath { get; set; }
        public long LastGamePlayed { get; set; } //Opgelet: formaat is unixtimeseconds -> yyyyMMddHHmmssffff dus je kan gewoon convertere naar int en dan vergelijke of het getal 10 miljard keer groter is
        public string BackGround { get; set; }
        public DateTime AccountCreatedDate { get; set; }
        public string ProfileTitle { get; set; }
        public int TotalGamesPlayed { get; set; }
        public int TotalBlyatsLost { get; set; }
    }
}