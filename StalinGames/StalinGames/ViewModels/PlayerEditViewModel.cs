using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StalinGames.ViewModels
{
    public class PlayerEditViewModel : RegisterViewModel
    {
        public string Id { get; set; }
        public string ProfilePicturePath { get; set; }

        [Required]
        public string ProfileTitle { get; set; }

        [Required]
        public string BackgroundName { get; set; }

        [DataType(DataType.Password)]
        public new string Password { get; set; }

        [DataType(DataType.Password)]
        public new string ConfirmPassword { get; set; }

        public IEnumerable<SelectListItem> ProfileTitles { get; set; }

        public IEnumerable<SelectListItem> BackgroundNames { get; set; }
    }
}