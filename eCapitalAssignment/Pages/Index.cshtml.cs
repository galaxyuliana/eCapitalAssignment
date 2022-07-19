using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using eCapitalAssignment.Models;

namespace eCapitalAssignment.Pages
{
    public class IndexModel : PageModelBase
    {
        public IList<Employee> Employee { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await GetEmployees();
        }
    }
}
