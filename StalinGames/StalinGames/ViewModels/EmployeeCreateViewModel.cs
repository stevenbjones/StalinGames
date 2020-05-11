using Microsoft.AspNetCore.Http;
using StalinGames.DAL.Models;

namespace StalinGames.ViewModels
{
    public class EmployeeCreateViewModel : Employee
    {
        public IFormFile Photo { get; set; }
    }
}