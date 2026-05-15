using System;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class ReviewRepository : IReviewRepository
{
    private readonly ApplicationDbContext _context;

    public ReviewRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task AddAsync(Review review)
    {
        throw new NotImplementedException();
    }

    public void Delete(Review review)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Review>> GetBookReviewsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Review?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Review>> GetUserReviewsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public void Update(Review review)
    {
        throw new NotImplementedException();
    }
}
