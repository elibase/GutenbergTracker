using System;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserBooksRepository : IUserBooksRepository
{
    private readonly ApplicationDbContext _context;

    public UserBooksRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<UserBook> AddUserBook(UserBook userBook)
    {
        userBook.DateStarted = DateTime.UtcNow;
        userBook.DateCompleted = null;

        _context.UserBooks.Add(userBook);
        await _context.SaveChangesAsync();
        return userBook;
    }

    public async Task<bool> DeleteUserBook(int id)
    {
        var ExistingBook = await _context.UserBooks.FindAsync(id);
        if (ExistingBook == null)
            return false;

        _context.Remove(ExistingBook);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Exists(int id)
    {
        return await _context.UserBooks.AnyAsync(e => e.Id == id);
    }

    public async Task<UserBook?> GerUserBookById(int id)
    {
        return await _context.UserBooks.FindAsync(id);
    }

    public async Task<ICollection<UserBook>> GetuserBooks(string userId)
    {
        return await _context.UserBooks
            .Where(ub => ub.UserId == userId)
            .Include(ub => ub.Book)
            .ToListAsync();
    }

    public async Task<UserBook?> UpdateUserBook(UserBook userBook)
    {
        var ExistingBook = await _context.UserBooks.FindAsync(userBook.Id);
        if(ExistingBook == null)
        {
            return null;
        }

        ExistingBook.DateCompleted = userBook.DateCompleted;
        ExistingBook.Notes = userBook.Notes;
        ExistingBook.Rating = userBook.Rating;
        ExistingBook.Status = userBook.Status;

        await _context.SaveChangesAsync();
        return ExistingBook;

    }
}
