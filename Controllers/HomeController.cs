using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ComputerShop.Models;

namespace ComputerShop.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Product()
    {
        return RedirectToAction(nameof(Menu));
    }

    public IActionResult Menu()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
         public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
