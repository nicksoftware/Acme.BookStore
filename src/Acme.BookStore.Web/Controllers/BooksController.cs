using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using InertiaCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Web;

[Route("[controller]")]
public class BooksController : AbpController
{

    private readonly IBookAppService _bookAppService;

    public BooksController(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }


    [HttpGet]
    public async Task<Response> Index()
    {
        //grab dotnet runtime version
        var runtime = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;

        var books = await _bookAppService.GetListAsync(
            new PagedAndSortedResultRequestDto()
            {

                SkipCount = 0,
                MaxResultCount = 10,
                Sorting = "Name"
            }
        );

        var data = new
        {
            runtime,
            books
        };

        return Inertia.Render("Books/Index", data);
    }

}
