using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCore.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCCore.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
public IActionResult Index()
{
    List<string> fruitList = new List<string>()
    { "Mango",
        "Apple",
        "Apricot",
        "Banana",
        "Grapes"
    };

    return View(fruitList);
}
    }
}
