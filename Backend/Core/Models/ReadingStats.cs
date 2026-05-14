using System;

namespace Core.Models;

public class ReadingStats
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int BooksCompleted { get; set; }
    public int BooksInProgress { get; set; }
    public int BooksDropped { get; set; }
    public int TotalBooksTracked { get; set; }
    public int ReadingStreak { get; set; }
    public int LongestReadingStreak { get; set; }
    public DateTime? LastReadingDate { get; set; }
}
