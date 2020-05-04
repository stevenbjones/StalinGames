using StalinGames.DAL.Models;
using Microsoft.AspNetCore.Http;

namespace StalinGames.ViewModels
{
    public class EmployeeCreateViewModel : Employee
    {
        public IFormFile Photo { get; set; }
    }
}
