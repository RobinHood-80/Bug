using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bug.Controllers
{
    [Route("/MvcDetail/{arg:int}")]
    public class MvcDetail : Controller
    {
        public IActionResult Index(int arg)
        {
            return View(arg);
        }
    }
}
