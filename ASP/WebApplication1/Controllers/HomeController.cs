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

    public IActionResult Product() {
        ViewBag.Message = "Product Lists";
        var products = new List<Product>
        {
            new Product {
                Id = 1,
                Name = "Laptops",
                Price = 999.99M                
            },
            new Product {
                Id = 2,
                Name = "SmartPhones",
                Price = 599.99M                
            },
            new Product {
                Id = 3,
                Name = "HeadPhones",
                Price = 79.99M                
            },
            new Product {
                Id = 4,
                Name = "AirPods",
                Price = 149.99M
            }
        };
        return View(products);
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
