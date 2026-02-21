using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DREAMHOTEL.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

    }
}
