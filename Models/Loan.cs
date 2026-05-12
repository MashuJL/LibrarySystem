
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Models;

public class Loan
{
    [Key]
    public int Id { get; set; }

    /* --- Foreign Keys --- */
    [Required]  
    public int BookId { get; set; }

    [Required]
    public string UserId { get; set; } = string.Empty;

    /* --- Loan Details --- */
    public DateTime LoanDate { get; set; } = DateTime.UtcNow;
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    /* --- Derived Properties --- */
    [NotMapped]
    public bool IsOverdue => ReturnDate == null && DateTime.UtcNow > DueDate;
    [NotMapped]
    public bool IsActive => ReturnDate == null;

    /* --- Navigation Properties --- */
    public Book Book { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;

}