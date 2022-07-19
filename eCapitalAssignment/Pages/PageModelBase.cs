using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using eCapitalAssignment.Data;
using eCapitalAssignment.Models;

namespace eCapitalAssignment.Pages
{
    #nullable disable
    public class PageModelBase : PageModel
    {
        protected eCapitalContext ECapitalContext => HttpContext.RequestServices.GetRequiredService<eCapitalContext>();

        protected async Task<List<Employee>> GetEmployees()
        {
            return await ECapitalContext.Employee.ToListAsync();
        }

        protected bool CheckEmployees(int id)
        {
            return ECapitalContext.Employee.Any(e => e.Id == id);
        }

        protected async Task AddEmployee(Employee employee)
        {
            ECapitalContext.Employee.Add(employee);
            await ECapitalContext.SaveChangesAsync();

        }

        protected async Task DeleteEmployeeAsync(int id)
        {
            Employee selectedEmployee = await GetEmployeeAsync(id);
            ECapitalContext.Employee.Remove(selectedEmployee);

            await ECapitalContext.SaveChangesAsync();
        }

        protected async Task UpdateEmployee(int id, Employee employee)
        {
            Employee selectedEmployee = await GetEmployeeAsync(id);
            selectedEmployee.FirstName = employee.FirstName;
            selectedEmployee.LastName = employee.LastName;
            selectedEmployee.Salary = employee.Salary;

            await ECapitalContext.SaveChangesAsync();
        }

        protected async Task<Employee> GetEmployeeAsync(int id)
        {
            return await ECapitalContext.Employee.FirstOrDefaultAsync(m => m.Id == id);
        }

    }
}
