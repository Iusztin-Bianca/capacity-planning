using CapacityPlanning.Domain.Entities;
using CapacityPlanning.Domain.Interfaces;
using CapacityPlanning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CapacityPlanning.Infrastructure.Repositories;

public class InitiativeRepository : Repository<Initiative>, IInitiativeRepository
{
    public InitiativeRepository(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<Initiative>> GetAllWithEpicsAsync() =>
        await _context.Initiatives.Include(i => i.Epics).ToListAsync();
}
