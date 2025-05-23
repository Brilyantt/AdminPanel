using Microsoft.AspNetCore.Mvc;

namespace MedicalProject.MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
