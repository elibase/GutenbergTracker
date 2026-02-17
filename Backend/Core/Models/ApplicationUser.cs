using System;
using Microsoft.AspNetCore.Identity;

namespace Core.Models;

public class ApplicationUser : IdentityUser
{
    public string? Name { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    public DateTime? LastLoginDate { get; set; }
    public ICollection<UserBook> UserBooks { get; set; } = new List<UserBook>();
}
