using System;
using Core.Models;

namespace Core.Interfaces;

public interface IUserBookRepository
{
    Task<IEnumerable<UserBook>> GetUserBooksAsync(int userId);
    Task<UserBook?> GetByIdAsync(int id);
    Task<UserBook?> GetUserBookAsync(int id, int gutenbergBookId);
    Task AddAsync(UserBook userBook);
    void Update(UserBook userBook);
    void Delete(UserBook userBook);
    Task SaveChangesAsync();
}
