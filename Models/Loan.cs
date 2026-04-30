namespace LibraryApp.Models;

public class Loan
{
    public required Book Book { get; set; }
    public required Customer Customer { get; set; }

    public DateTime LoanDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public DateTime DueDate { get; set; }

    public bool IsReturned => ReturnDate.HasValue;
}