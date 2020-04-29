using EmployeeManagment.DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;

namespace EmployeeManagment.ViewModels
{
    public class EmployeeCreateViewModel : Employee
    {
        public IFormFile Photo { get; set; }
    }
}
