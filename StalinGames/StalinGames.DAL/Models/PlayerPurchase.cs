using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

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
