using System;
using Microsoft.AspNetCore.Identity;

namespace Core.Models;

public class User : IdentityUser
{
    public string? Name { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    public DateTime? LastLoginDate { get; set; }
     public ReadingStats? ReadingStats { get; set; }
    public ICollection<UserBook> UserBooks { get; set; } = new List<UserBook>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
