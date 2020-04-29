using System.Collections.Generic;
using EmployeeManagment.DataAccessLayer.Context;
using EmployeeManagment.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeManagment.DataAccessLayer.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        private readonly ILogger<EmployeeRepository> _logger;

        public EmployeeRepository(AppDbContext context, ILogger<EmployeeRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Employee> GetAll()
        {
            var listEmployees = _context.Employees;
            return listEmployees;
        }

        public Employee GetById(int id)
        {
            _logger.LogTrace("Trace Log");
            _logger.LogDebug("Debug Log");
            _logger.LogInformation("Information Log");
            _logger.LogWarning("Warning Log");
            _logger.LogError("Error Log");
            _logger.LogCritical("Critical Log");

            var employee = _context.Employees.Find(id);
            return employee;
        }

        public Employee Add(Employee employee)
        {
            var newEmployee = _context.Employees.Add(employee);

            if (newEmployee != null && newEmployee.State == EntityState.Added)
            {
                var affectedRows = _context.SaveChanges();

                if (affectedRows > 0)
                {
                    return newEmployee.Entity;
                }
            }

            return null;
        }

        public Employee Delete(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee != null)
            {
                var deletedEmployee = _context.Employees.Remove(employee);

                if (deletedEmployee != null && deletedEmployee.State == EntityState.Deleted)
                {
                    var affectedRows = _context.SaveChanges();

                    if (affectedRows > 0)
                    {
                        return deletedEmployee.Entity;
                    }
                }
            }

            return null;
        }

        public Employee Update(Employee employee)
        {
            var newEmployee = _context.Employees.Update(employee);

            if (newEmployee != null && newEmployee.State == EntityState.Modified)
            {
                var affectedRows = _context.SaveChanges();

                if (affectedRows > 0)
                {
                    return newEmployee.Entity;
                }
            }

            return null;
        }
    }
}
