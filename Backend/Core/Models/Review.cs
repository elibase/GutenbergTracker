using System;
using System.Collections.Specialized;

namespace Core.Models;

public class Review
{
    public int Id { get; set; } 
    public int UserId { get; set; }
    public int GutenBergId { get; set; }
    public string BookTitle { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int Rating { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}
