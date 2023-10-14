using System;
using InertiaCore;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Web;

[Route("/")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        //grab dotnet runtime version
        var runtime = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;

        var data = new
        {
            runtime
        };

        return Inertia.Render("Index", data);
    }

}
