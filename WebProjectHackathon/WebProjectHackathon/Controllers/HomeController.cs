using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebProjectHackathon.BusinessLogic.Service;
using WebProjectHackathon.Models;

namespace WebProjectHackathon.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _Intex;
    private readonly IProfessionsService _service;

    public HomeController(ILogger<HomeController> intex, IProfessionsService service)
    {
        _Intex = intex;
        _service = service;
    }

    public async Task<IActionResult> IndexAsync()
    {
        List<ProfessionModel> professions = await _service.GetAllProfessions();
        return View(professions);
    }

    public IActionResult PageHRMap()
    {
        return View();
    }

    public IActionResult PageBackEndMap()
    {
        return View();
    }

    public IActionResult PageFrondEndMap()
    {
        return View();
    }

    public IActionResult PageUXUIDesignerMap()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
