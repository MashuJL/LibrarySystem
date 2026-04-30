using Microsoft.EntityFrameworkCore;
using LibraryApp.Models;

namespace LibraryApp.Data;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options) { }

    public DbSet<LibraryApp.Models.Book> Books { get; set; }
    public DbSet<LibraryApp.Models.Customer> Customers { get; set; }
    public DbSet<LibraryApp.Models.Loan> Rents { get; set; }
}
