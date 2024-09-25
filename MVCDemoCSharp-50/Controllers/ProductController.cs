using Microsoft.AspNetCore.Mvc;
using MVCDemoCSharp_50.Data;

namespace MVCDemoCSharp_50.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _repo;

    public ProductController(IProductRepository repo)
    {
        _repo = repo;
    }
    // GET
    public IActionResult Index()
    {
        var products = _repo.GetAllProducts();
        return View(products);
    }
}