using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Shop.Models;

namespace Shop.Controllers;

public class ProductController : Controller
{
    private static List<Product> _products = new()
    {   new Product
        {
            Id = 0,
            Name = "BMW X5",
            Category = "Car",
            Price = 120000
        },
        new Product
        {
            Id = 1,
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
    public IActionResult ProductAddForm()
    {
        return View();
    }

    // action to add the new product to _products
    [HttpPost]
    public IActionResult ProductAddForm(Product product)
    {
        // validate new product
        // add it to _products
        _products.Add(product);
        // go to Index page
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult ProductEditForm(Product product)
    {
        // validate new product
        // Edit the product in _products
        var originalproduct = _products[product.Id];

        originalproduct.Name = product.Name;
        originalproduct.Price = product.Price;
        originalproduct.Category = product.Category;

        // go to Index page
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int Id)
    {
        var product = _products[Id];
        if (_products.Count != 0)
            _products.Remove(product);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int Id)
    {
        var product = _products[Id];
        return View("ProductEditForm", product);
    }






}