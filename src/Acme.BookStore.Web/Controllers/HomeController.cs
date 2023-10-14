using System;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Web;

[Route("/")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
