using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BuilderCompany.Models;
using BuilderCompany.Data;
using Microsoft.EntityFrameworkCore;

namespace BuilderCompany.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new HomeViewModel
        {
            Services = await _context.Services.ToListAsync(),
            Projects = await _context.Projects.ToListAsync()
        };
        
        return View(viewModel);
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