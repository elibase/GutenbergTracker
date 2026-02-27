using System;
using Core.Models;

namespace Core.Interfaces;

public interface IUserBooksRepository
{   
    Task<ICollection<UserBook>> GetuserBooks(string userId);
    Task<UserBook?> GerUserBookById(int id);
    Task<UserBook> AddUserBook(UserBook userBook);
    Task<UserBook?> UpdateUserBook(UserBook userBook);
    Task<bool> DeleteUserBook(int id);
    Task<bool> Exists(int id);
}
