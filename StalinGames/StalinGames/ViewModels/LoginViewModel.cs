using System.ComponentModel.DataAnnotations;

namespace StalinGames.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        //[EmailAddress]
        //[RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        //    ErrorMessage = "Email must be a valid Address Email.")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
