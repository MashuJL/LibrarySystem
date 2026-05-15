using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryApp.Pages.Account;

public class ForgotPasswordModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; } = new();

    public class InputModel
    {
        public string Email { get; set; } = string.Empty;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
        return Page();
    }
}