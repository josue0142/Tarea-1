using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tarea1.Controllers
{
    public class EcuacionController : Controller
    {
        [HttpGet]
        public IActionResult EquationCalculate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EquationCalculate(double varA, double varB, double varC)
        {
            ViewBag.ResultadoX1 = (-varB + (Math.Sqrt(Math.Pow(varB, 2) - 4 * varA * varC))) / (2 * varA);

            ViewBag.ResultadoX2 = (-varB - (Math.Sqrt(Math.Pow(varB, 2) - 4 * varA * varC))) / (2 * varA);

            return View("EquationCalculate");
        }
    }
}