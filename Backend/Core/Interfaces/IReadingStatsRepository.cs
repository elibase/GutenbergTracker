using System;
using Core.Models;

namespace Core.Interfaces;

public interface IReadingStatsRepository
{
    Task<ReadingStats?> GetByUserIdAsync(int id);
    Task CreateAsync(ReadingStats stats);
    Task<Review?> GetByIdAsync(int id);
    void Update(ReadingStats stats); 
    Task SaveChangesAsync();
}
