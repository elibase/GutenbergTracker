using System;
using Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<UserBook> UserBooks { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<ReadingStats> ReadingStats { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

         // User
        builder.Entity<User>(entity =>
        {
            entity.ToTable("Users");

            entity.HasMany(u => u.UserBooks)
                .WithOne(ub => ub.User)
                .HasForeignKey(ub => ub.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(u => u.ReadingStats)
                .WithOne(rs => rs.User)
                .HasForeignKey<ReadingStats>(rs => rs.UserId);
        });

        // Prevent duplicate user-book entries
        builder.Entity<UserBook>()
            .HasIndex(ub => new { ub.UserId, ub.GutenbergBookId })
            .IsUnique();
    }
}
