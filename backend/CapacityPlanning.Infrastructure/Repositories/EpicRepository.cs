using CapacityPlanning.Domain.Entities;
using CapacityPlanning.Domain.Interfaces;
using CapacityPlanning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CapacityPlanning.Infrastructure.Repositories;

public class EpicRepository : Repository<Epic>, IEpicRepository
{
    public EpicRepository(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<Epic>> GetByInitiativeAsync(Guid initiativeId) =>
        await _context.Epics.Where(e => e.InitiativeId == initiativeId).ToListAsync();

    public async Task<IEnumerable<Epic>> GetInDateRangeAsync(DateTime startDate, DateTime endDate) =>
        await _context.Epics.Where(e => e.StartDate <= endDate && e.DueDate >= startDate).ToListAsync();
}
