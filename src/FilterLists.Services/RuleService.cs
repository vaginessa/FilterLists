using System.Linq;
using System.Threading.Tasks;
using FilterLists.Data;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services
{
    [UsedImplicitly]
    public class RuleService : Service
    {
        public RuleService(FilterListsDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<int> GetCountAll() =>
            await DbContext.Snapshots
                           .AsNoTracking()
                           .Where(s => s.WasUpdated && s.WasSuccessful)
                           .OrderByDescending(s => s.CreatedDateUtc)
                           .GroupBy(s => s.FilterListId)
                           .Select(g => g.FirstOrDefault())
                           .SelectMany(s => s.SnapshotRules)
                           .GroupBy(sr => sr.RuleId)
                           .CountAsync();
    }
}