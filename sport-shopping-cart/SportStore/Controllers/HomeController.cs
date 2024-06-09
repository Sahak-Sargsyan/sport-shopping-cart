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

    public ViewResult Index(int prodPage = 1)
    {
        return View(new ProductsListViewModel
        {
            Products = storeRepository.Products
                    .OrderBy(p => p.ProductId)
                    .Skip((prodPage - 1) * PageSize)
                    .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = prodPage,
                ItemsPerPage = PageSize,
                TotalItems = storeRepository.Products.Count()
            }
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
