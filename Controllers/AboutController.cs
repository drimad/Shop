using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers;

public class AboutController : Controller
{
    public IActionResult Info()
    {
        return View();
    }
}