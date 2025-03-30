using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebProjectHackathon.Models;

public class PersonalityUserPagesController : Controller
{
    private readonly ILogger<HomeController> _Intex;

    public PersonalityUserPagesController(ILogger<HomeController> intex)
    {
        _Intex = intex;
    }

    public IActionResult Authorization()
    {
        return View();
    }
    public IActionResult PersonalOffice()
    {
        return View();
    }
    public IActionResult Registration()
    {
        return View();
    }
}
