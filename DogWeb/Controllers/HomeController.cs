using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DogWeb.Models;
using DogWeb.Wrappers;

namespace DogWeb.Controllers;

public class HomeController : Controller
{
    private readonly IDogServiceWrapper dogServiceWrapper;

    public HomeController(IDogServiceWrapper dogServiceWrapper)
    {
        this.dogServiceWrapper = dogServiceWrapper;
    }

    public async Task<IActionResult> Index()
    {
        var allDogs = await dogServiceWrapper.GetAllDogsAsync();

        return View(allDogs);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
