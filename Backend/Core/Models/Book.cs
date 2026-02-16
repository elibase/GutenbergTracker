using System;

namespace Core.Models;

public class Book
{
    public int Id { get; set; }
    public int GutenberId { get; set; }
    public int AuthorId { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Summary { get; set; }
    public string? CoverImageUrl { get; set; }
    public double ReadingEaseScore { get; set; }
    public ICollection<UserBook> UserBooks { get; set; } = new List<UserBook>();
}
