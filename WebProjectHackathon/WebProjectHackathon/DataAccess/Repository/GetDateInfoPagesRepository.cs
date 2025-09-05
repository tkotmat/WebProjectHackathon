using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.DataAccess.Entity;

namespace WebProjectHackathon.DataAccess.Repository
{
    public class GetDateInfoPagesRepository : IGetDateInfoPagesRepository
    {
        private readonly DatabaseContext _context;
        public GetDateInfoPagesRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<CircleContextPagesInfoEntity>> GetAllCircle(int idContextHomePages)
        {
            return await _context.CircleContextPagesInfos
                .Where(c => c.IdContextHomePages == idContextHomePages)
                .ToListAsync();
        }

        public async Task<List<MainPanelContextEntity>> GetAllMainPanel(int idContextHomePages, int idCircleContextPagesInfo)
        {
            return await _context.MainPanelContexts
                .Where(m => m.CircleContextPagesInfoEntityId == idCircleContextPagesInfo
                            && m.CircleContextPageInfo.IdContextHomePages == idContextHomePages)
                .Include(m => m.CircleContextPageInfo)
                .ToListAsync();
        }
    }
    public interface IGetDateInfoPagesRepository
    {
        public Task<List<CircleContextPagesInfoEntity>> GetAllCircle(int idContextHomePages);
        public Task<List<MainPanelContextEntity>> GetAllMainPanel(int idContextHomePages, int idCircleContextPagesInfo);
    }
}
