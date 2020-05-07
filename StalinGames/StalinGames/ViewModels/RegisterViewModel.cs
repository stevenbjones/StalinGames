using System.ComponentModel.DataAnnotations;
using StalinGames.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace StalinGames.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Remote(action: "IsUsernameInUse",
            controller: "Account")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Email must be a valid Address Email.")]
        [Remote(action: "IsEmailInUse",
            controller: "Account")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Comfirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public IFormFile Photo { get; set; }
    }
}
