using Core.Interfaces;
using Core.Models;

namespace Infrastructure.Repositories;

public class UserBooksRepository : IUserBookRepository
{
    public Task AddAsync(UserBook userBook)
    {
        throw new NotImplementedException();
    }

    public void Delete(UserBook userBook)
    {
        throw new NotImplementedException();
    }

    public Task<UserBook?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<UserBook?> GetUserBookAsync(int id, int gutenbergBookId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserBook>> GetUserBooksAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public void Update(UserBook userBook)
    {
        throw new NotImplementedException();
    }
}
