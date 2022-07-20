using eCapitalAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eCapitalAssignment.Pages
{
    public class UpsertModel : PageModelBase
    {
        [BindProperty]
        public Employee Employee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync([FromRoute]int? id)
        {
            if (id != null)
            {
                var selectedEmployee = await GetEmployeeAsync((int)id);

                if (selectedEmployee == null)
                {
                    return NotFound();
                }

                Employee = selectedEmployee;
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync([FromRoute]int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (id == null)
            {
                await AddEmployee(Employee);
            }
            else if (id > 0 && Employee != null)
            {
                await UpdateEmployee((int)id, Employee);
            }
            else
            {
                return Redirect("/");
            }

            return Redirect("/");
        }
    }
}
