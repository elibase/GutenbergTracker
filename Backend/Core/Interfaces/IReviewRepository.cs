using System;
using Core.Models;

namespace Core.Interfaces;

public interface IReviewRepository
{
    Task<IEnumerable<Review>> GetBookReviewsAsync(int id);
    Task<IEnumerable<Review>> GetUserReviewsAsync(int id);
    Task<Review?> GetByIdAsync(Guid id);
    Task AddAsync(Review review);
    void Update(Review review);
    void Delete(Review review);

    Task SaveChangesAsync();
}
