using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Shop.Models;

namespace Shop.Controllers;

public class ProductController : Controller
{
    private List<Product> _products = new();
    public ProductController()
    {
        var p1 = new Product
        {
            Id = 1,
            Name = "BMW X5",
            Category = "Car",
            Price = 120000
        };

        var p2 = new Product
        {
            Id = 2,
            Name = "BMW X6",
            Category = "Car",
            Price = 140000
        };
        _products.Add(p1);
        _products.Add(p2);
    }
    public IActionResult Index()
    {
        ViewBag.ListOfProducts = _products;
        return View();
    }
}