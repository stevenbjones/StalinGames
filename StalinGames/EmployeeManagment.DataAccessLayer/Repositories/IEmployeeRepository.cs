using System.Collections.Generic;
using EmployeeManagment.DataAccessLayer.Models;

namespace EmployeeManagment.DataAccessLayer.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        Employee Delete(int id);
    }
}
