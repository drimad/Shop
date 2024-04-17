using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Shop.Models;

namespace Shop.Controllers;

public class ProductController : Controller
{
    private static List<Product> _products = new()
    {   new Product
        {
            Id = 1,
            Name = "BMW X5",
            Category = "Car",
            Price = 120000
        },
        new Product
        {
            Id = 2,
            Name = "BMW X6",
            Category = "Car",
            Price = 140000
        }
    };

    [HttpGet] // annotations
    public IActionResult Index()
    {
        return View(_products);
    }

    // action to display the form
    [HttpGet]
    public IActionResult ProductForm()
    {
        return View();
    }

    // action to add the new product to _products
    [HttpPost]
    public IActionResult ProductForm(Product product)
    {
        // validate new product
        // add it to _products
        _products.Add(product);
        // go to Index page
        return RedirectToAction("Index");
    }
}