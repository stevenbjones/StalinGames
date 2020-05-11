using System.ComponentModel.DataAnnotations;

namespace StalinGames.DAL.Models
{
    public class PlayerPurchase
    {
        [Key]
        [Required]
        public string OrderID { get; set; }

        [Required]
        public string UserID { get; set; }

        [Required]
        public string ItemID { get; set; }
    }
}