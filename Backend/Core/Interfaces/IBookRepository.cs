using System;
using Core.Models;

namespace Core.Interfaces;

public interface IBookRepository
{
    Task<ICollection<Book>> GetBooksAsync();
    Task<Book?> GetBookByIdAsync(int id);
    
}
