using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.DataAccess.Entity;

namespace WebProjectHackathon.DataAccess.Repository
{
    public class ProfessionsRepository : IProfessionsRepository
    {
        private readonly DatabaseContext _context;
        public ProfessionsRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<ContextHomePagesEntity>> GetAllProfessions()
        {
            return await _context.ContextHomePages.ToListAsync();
        }

        public async Task<List<int>> GetAllIds()
        {
            return await _context.ContextHomePages
                .Select(p => p.Id)
                .ToListAsync();
        }
    }

    public interface IProfessionsRepository
    {
        public Task<List<ContextHomePagesEntity>> GetAllProfessions();
        public Task<List<int>> GetAllIds();
    }
}
