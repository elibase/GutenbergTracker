using System;
using Core.Enums;

namespace Core.Models;

public class UserBook
{
    public int Id { get; set; }
    public required string UserId { get; set; }
    public User? User { get; set; }
    public int GutenbergBookId { get; set; }
    public string Title { get; set; } = string.Empty;
    public List<string> Authors { get; set; } = [];
    public string CoverImageUrl { get; set; } = string.Empty;
    public ReadingStatus Status { get; set; }
    public DateTime? DateStarted { get; set; }
    public DateTime? DateCompleted { get; set; }
    public DateTime DateLastRead { get; set; } = DateTime.UtcNow;
}

