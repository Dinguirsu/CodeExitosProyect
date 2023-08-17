using CodeExitosProyect.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CodeExitosProyect.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ShoppingWebAppContext _context;

        public EmployeeController(ShoppingWebAppContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Employees.ToList());
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost("[action]")]
        public async Task<OkResult> Add(NewEmployeeModel newEmployee)
        {
            try
            {
                Employee employee = new Employee();
                employee.Name = newEmployee.Name;
                employee.Address = newEmployee.Address;
                employee.EmploymentDate = newEmployee.EmploymentDate;
                employee.Telefhone = newEmployee.Telefhone;
                employee.Type = newEmployee.Type;

                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();

                return await Task.Run(Ok);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
