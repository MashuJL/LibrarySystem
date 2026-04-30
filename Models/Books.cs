namespace LibraryApp.Models;

public class Book
{
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required string Genre { get; set; }
    public string? ISBN { get; set; }
    public int? Year { get; set; }

    public bool IsAvailable { get; set; } = true;
}
