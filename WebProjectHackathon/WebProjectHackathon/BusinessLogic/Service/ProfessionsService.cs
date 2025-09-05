using WebProjectHackathon.BusinessLogic.Models;
using WebProjectHackathon.DataAccess.Repository;

namespace WebProjectHackathon.BusinessLogic.Service
{
    public class ProfessionsService : IProfessionsService
    {
        private readonly IProfessionsRepository _professionsRepository;

        public ProfessionsService(IProfessionsRepository professionsRepository)
        {
            _professionsRepository = professionsRepository;
        }

        public async Task<List<ProfessionModel>> GetAllProfessions()
        {
            var entities = await _professionsRepository.GetAllProfessions();
            return entities.Select(e => new ProfessionModel
            {
                Title = e.Title,
                Description = e.Description,
            }).ToList();
        }
    }

    public interface IProfessionsService
    {
        public Task<List<ProfessionModel>> GetAllProfessions();
    }
}
