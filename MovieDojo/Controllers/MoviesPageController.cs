using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MovieDojo.Controllers
{
    public class MoviesPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
