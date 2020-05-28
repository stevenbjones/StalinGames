using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StalinGames.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        [Required]
        [Remote(action: "BlyatsCheck",
            controller: "Administration")]
        public double Blyats { get; set; }
        [Required]
        public string Role { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}