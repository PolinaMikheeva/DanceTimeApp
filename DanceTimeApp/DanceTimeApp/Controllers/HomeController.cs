using DanceTimeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DanceTimeApp.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Main()
    {
        var directions = _context.Directions.ToList();
        return View(directions);
    }
    public IActionResult Trainers()
    {
        return View();
    }
    public IActionResult InfoTrainer()
    {
        return View();
    }
    public IActionResult Schedule()
    {
        return View();
    }
    public IActionResult Records()
    {
        return View();
    }
    public IActionResult Signin()
    {
        return View();
    }
    public IActionResult Registration()
    {
        return View();
    }
}