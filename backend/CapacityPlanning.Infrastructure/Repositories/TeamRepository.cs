using CapacityPlanning.Domain.Entities;
using CapacityPlanning.Domain.Interfaces;
using CapacityPlanning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CapacityPlanning.Infrastructure.Repositories;

public class TeamRepository : Repository<Team>, ITeamRepository
{
    public TeamRepository(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<Team>> GetAllWithMembersAsync() =>
        await _context.Teams.Include(t => t.Members).ToListAsync();

    public async Task<Team?> GetWithMembersAsync(Guid id) =>
        await _context.Teams.Include(t => t.Members).FirstOrDefaultAsync(t => t.Id == id);
}
