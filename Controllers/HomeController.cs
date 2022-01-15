using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projectC.Models;

namespace projectC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
