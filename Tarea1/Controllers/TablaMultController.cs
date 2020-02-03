using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tarea1.Controllers
{
    public class TablaMultController : Controller
    {
        public IActionResult MultiplicationTables()
        {
            return View();
        }
    }
}