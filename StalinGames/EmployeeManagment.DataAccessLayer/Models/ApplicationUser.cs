using Microsoft.AspNetCore.Identity;

namespace EmployeeManagment.DataAccessLayer.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
