using Microsoft.AspNetCore.Identity;

namespace LibraryApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName {get; set; } = string.Empty;
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;

        /* --- Navigation Properties (All loans beloning too this user) --- */
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}

