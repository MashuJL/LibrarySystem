/**
* Book.cs
* 
* Represents a book in the library system.
* Contains properties for book details and availability status.
* Includes data annotations for validation and database mapping.
*/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Models;

public class Book
{
    [Key]
    public int Id { get; set; } // EF core 

    [Required, MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    [Required, MaxLength(100)]
    public string Author { get; set; } = string.Empty;

    [Required, MaxLength(100)]
    public string Genre { get; set; } = string.Empty;

    [Required]
    [Range(1450, 2100, ErrorMessage = "Please enter a valid year.(1450 - 2100)")]
    public int Year { get; set; }

    [Required, MaxLength(100)]
    public string Publisher { get; set; } = string.Empty;

    [Required, MaxLength(20)]
    public string BookId { get; set; } = string.Empty;

    [Required, MaxLength(20)]
    public string ISBN { get; set; } = string.Empty;

    /* --- AVAILABILITY --- */

    [NotMapped]
    public bool IsAvailable => CurrentLoan == null;

    [NotMapped]
    public Loan? CurrentLoan { get; set; }

    /* --- Navigation Properties --- */
    public ICollection<Loan> Loans { get; set; } = new List<Loan>();

}
