using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using eCapitalAssignment.Models;

namespace eCapitalAssignment.Pages.Employees
{
    public class IndexModel : PageModelBase
    {
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public IList<Employee> Employee { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await GetEmployees(SearchString);
        }
        public async Task<RedirectResult> OnPostAsync([FromRoute] int id)
        {
            if (CheckEmployees(id))
            {
                await DeleteEmployeeAsync(id);
            }

            return Redirect("/");
        }
    }
}
