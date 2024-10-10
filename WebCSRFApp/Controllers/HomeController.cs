using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebCSRFApp.Models;

namespace WebCSRFApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken] // Validates the anti-forgery token
    public IActionResult SubmitForm(string someInput)
    {
        // Process the form data
        return RedirectToAction("Privacy");
    }

}
