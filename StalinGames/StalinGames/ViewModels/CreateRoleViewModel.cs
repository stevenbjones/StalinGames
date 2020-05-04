using System.ComponentModel.DataAnnotations;

namespace StalinGames.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
