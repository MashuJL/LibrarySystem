using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryApp.Pages.Account;

public class RegisterModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; } = new();
    
    public class InputModel
    {
        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string ConfirmPassword { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow.AddYears(-18); // Default to 18 years ago
    }

    public void OnGet()
    {
    
    }

    public IActionResult OnPost()
    {
        return Page();
    }
}