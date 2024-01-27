using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // dummy data for demonstration
        var products = new List<Product>
        {
            new Product {
                Id = 1,
                Name = "Laptop",
                Price = 999.99M
            },
            new Product {
                Id = 2,
                Name = "SmartPhones",
                Price = 499.99M
            },
            new Product {
                Id = 3,
                Name = "SmartPhones",
                Price = 499.99M
            },
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
