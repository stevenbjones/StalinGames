using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StalinGames.DAL.Models
{
    public class BackgroundPicture : PlayerItem
    {
        public string BackgroundPath { get; set; }
    }
}
