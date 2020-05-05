using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using StalinGames.Utilities;

namespace StalinGames.ViewModels
{
    public class EditUserViewModel
    {
 
        public string Id { get; set; }

        public string UserName { get; set; }    
        public int Blyats { get; set; }
        public string Role { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}
