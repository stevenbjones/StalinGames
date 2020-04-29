using System.ComponentModel.DataAnnotations;
using EmployeeManagment.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagment.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Email must be a valid Address Email.")]
        [Remote(action: "IsEmailInUse",
            controller: "Account")]
        [ValidEmailDomain(allowedDomain: "test.com",
            ErrorMessage = "Email domain must be test.com")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Comfirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string City { get; set; }
    }
}
