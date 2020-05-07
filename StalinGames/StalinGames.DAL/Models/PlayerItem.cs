using System.ComponentModel.DataAnnotations;

namespace StalinGames.DAL.Models
{
    public class PlayerItem
    {
        [Key]
        public string ItemID { get; set; }
        public ItemType itemType { get; set; }
        public int Price { get; set; }
    }
}