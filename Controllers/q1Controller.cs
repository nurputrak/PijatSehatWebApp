using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PijatSehat.Models;

namespace PijatSehat.Controllers;

public class q1Controller : Controller
{
    private readonly ILogger<q1Controller> _logger;

    public q1Controller(ILogger<q1Controller> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult profile()
    {
        return View();
    }

    public IActionResult company()
    {
        return View();
    }
    public IActionResult service()
    {
        return View();
    }
    public IActionResult collaboration()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
