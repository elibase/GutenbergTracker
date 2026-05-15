using System;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class ReadingStatsRepository : IReadingStatsRepository
{
    private readonly ApplicationDbContext _context;

    public ReadingStatsRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task CreateAsync(ReadingStats stats)
    {
        throw new NotImplementedException();
    }

    public Task<Review?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ReadingStats?> GetByUserIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public void Update(ReadingStats stats)
    {
        throw new NotImplementedException();
    }
}
