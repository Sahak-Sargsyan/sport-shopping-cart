using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers;

public class HomeController : Controller
{
    private readonly IStoreRepository storeRepository;

    public HomeController(IStoreRepository repo)
    {
        storeRepository = repo;
    }

    public int PageSize = 4;

    public ViewResult Index(string? category, int prodPage = 1)
    {
        return View(new ProductsListViewModel
        {
            Products = storeRepository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductId)
                    .Skip((prodPage - 1) * PageSize)
                    .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = prodPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ? storeRepository.Products.Count() 
                : storeRepository.Products.Where(e => e.Category == category).Count()
            },
            CurrentCategory = category
        });
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
