using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers;

public class SourceController : Controller
{
    // GET
    public SourceController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }
}