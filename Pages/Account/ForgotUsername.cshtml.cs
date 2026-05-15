using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryApp.Pages.Account;
public class ForgotUsernameModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; } = new();

    public class InputModel
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }

    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
        return Page();
    }
}