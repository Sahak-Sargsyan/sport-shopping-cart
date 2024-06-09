using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Controllers;

public class HomeController : Controller
{
    private readonly IStoreRepository storeRepository;

    public HomeController(IStoreRepository repo)
    {
        storeRepository = repo;
    }

    public IActionResult Index()
    {
        return View(storeRepository.Products);
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
