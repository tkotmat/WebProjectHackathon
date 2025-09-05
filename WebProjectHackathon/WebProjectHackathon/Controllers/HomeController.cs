using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebProjectHackathon.BusinessLogic.Models;
using WebProjectHackathon.BusinessLogic.Service;

namespace WebProjectHackathon.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _Intex;
    private readonly IProfessionsService _service;
    private readonly IProcessThePageDataService _processThePageDataService;

    public HomeController(ILogger<HomeController> intex, IProfessionsService service, IProcessThePageDataService processThePageDataService)
    {
        _Intex = intex;
        _service = service;
        _processThePageDataService = processThePageDataService;
    }

    public async Task<IActionResult> IndexAsync()
    {
        List<ProfessionModel> professions = await _service.GetAllProfessions();
        return View(professions);
    }

    public async Task<IActionResult> PageHRMapAsync()
    {
        List<TitleModelCircle> titleModelCircles = await _processThePageDataService.GetDataForThePage("HR");
        return View(titleModelCircles);
    }

    public async Task<IActionResult> PageBackEndMapAsync()
    {
        List<TitleModelCircle> titleModelCircles = await _processThePageDataService.GetDataForThePage("backend");
        return View(titleModelCircles);
    }

    public async Task<IActionResult> PageFrondEndMapAsync()
    {
        List<TitleModelCircle> titleModelCircles = await _processThePageDataService.GetDataForThePage("frondend");
        return View(titleModelCircles);
    }

    public async Task<IActionResult> PageUXUIDesignerMapAsync()
    {
        List<TitleModelCircle> titleModelCircles = await _processThePageDataService.GetDataForThePage("uxui");
        return View(titleModelCircles);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
