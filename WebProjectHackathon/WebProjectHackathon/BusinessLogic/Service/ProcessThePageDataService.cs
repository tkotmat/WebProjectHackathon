using WebProjectHackathon.BusinessLogic.Models;
using WebProjectHackathon.DataAccess.Repository;

namespace WebProjectHackathon.BusinessLogic.Service
{
    public class ProcessThePageDataService : IProcessThePageDataService
    {
        public readonly IProfessionsRepository _professionsRepository;
        public readonly IGetDateInfoPagesRepository _getDateInfoPages;

        public ProcessThePageDataService(IGetDateInfoPagesRepository getDateInfoPages, IProfessionsRepository professionsRepository)
        {
            _getDateInfoPages = getDateInfoPages;
            _professionsRepository = professionsRepository;
        }

        public async Task<List<TitleModelCircle>> GetDataForThePage(string namePages)
        {
            List<int> IdProfessions = await _professionsRepository.GetAllIds();

            namePages = namePages.ToLower();

            switch (namePages)
            {
                case "frondend":
                    return await GetTheDataPage(IdProfessions[0]);

                case "backend":
                    return await GetTheDataPage(IdProfessions[1]);

                case "hr":
                    return await GetTheDataPage(IdProfessions[2]);

                case "uxui":
                    return await GetTheDataPage(IdProfessions[3]);
            }
            return new List<TitleModelCircle>
            {
                new TitleModelCircle
                {
                    Title = "Error 404",
                    Description = "Page not found",
                    Panels = new List<PanelMainModel>
                    {
                        new PanelMainModel
                        {
                            Title = "Error",
                            Content = "The page you are looking for does not exist.",
                            ImageUrl = ""
                        }
                    }
                }
            };
        }

        private async Task<List<TitleModelCircle>> GetTheDataPage(int IdProfessions)
        {
            var circles = await _getDateInfoPages.GetAllCircle(IdProfessions);

            var result = new List<TitleModelCircle>();

            foreach (var circle in circles)
            {
                var mainPanels = await _getDateInfoPages.GetAllMainPanel(IdProfessions, circle.Id);

                var model = new TitleModelCircle
                {
                    Title = circle.Title,
                    Description = circle.Description,
                    Panels = mainPanels.Select(mp => new PanelMainModel
                    {
                        Title = mp.Title,
                        Content = mp.Context,
                        ImageUrl = mp.Url
                    }).ToList()
                };

                result.Add(model);
            }

            return result;
        }
    }

    public interface IProcessThePageDataService
    {
        public Task<List<TitleModelCircle>> GetDataForThePage(string namePages);
    }
}
