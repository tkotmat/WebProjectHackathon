using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebProjectHackathon.Models;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _Intex;

    public HomeController(ILogger<HomeController> intex)
    {
        _Intex = intex;
    }

    public IActionResult Index()
    {
        return View();
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
