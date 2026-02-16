using System;
using Core.Enums;

namespace Core.Models;

public class UserBook
{
    public int Id { get; set; }
    public required string UserId { get; set; }
    public ApplicationUser? User { get; set; }
    public int BookId { get; set; }
    public Book? Book { get; set; }
    public ReadingStatus Status { get; set; }
    public int? Rating { get; set; }
    public string? Notes { get; set; }
    public DateTime? DateStarted { get; set; }
    public DateTime? DateCompleted { get; set; }
}

