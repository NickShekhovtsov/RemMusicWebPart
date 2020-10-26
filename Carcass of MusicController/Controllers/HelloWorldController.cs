using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Carcass_of_MusicController.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            TempData["buttonval"] = "12345678";
            int i = 12377;
            string z = i.ToString();
            TempData["buttonval"] = z;
            return RedirectToAction("Index");
        }

        public IActionResult Welcome2()
        {
            return RedirectToAction("Index");
        }
    }
}
