using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        // return Content("Welcome to the Home Page!");
        ViewData["Message"] = "Welcome to ASP.NET MVC!";
        return View();
    }

    public IActionResult About() {
        // return Content("This is the About Page.");
        ViewData["Message"] = "Your application description page.";
        return View();
    }

    public IActionResult Contact() {
        // return Content("You can contact us at contact@example.com.");
        ViewBag.Message = "Your contact page.";
        return View();

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
