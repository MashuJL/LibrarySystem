namespace LibraryApp.Models;

public abstract class Customer : User
{
    public List<Loan> BorrowedBooks { get; set; } = new List<Loan>();
}