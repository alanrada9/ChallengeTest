using ChallengeService.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<Card> Cards { get; set; }
        DbSet<Account> Accounts { get; set; }
        DbSet<Transaction> Transactions { get; set; }
        DbSet<T> Set<T>() where T : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}