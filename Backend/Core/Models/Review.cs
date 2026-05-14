using System;
using System.Collections.Specialized;

namespace Core.Models;

public class Review
{
    public int Id { get; set; } 
    public int UserId { get; set; }
    public int Rating { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
