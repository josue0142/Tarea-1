using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tarea1.Controllers
{
    public class SignoZodiacalController : Controller
    {
        [HttpGet]
        public IActionResult CalculateZodiacSign()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateZodiacSign(DateTime date1)
        {
            int day = date1.Day;
            var Month = date1.Month;

            //Capricornio 22 de diciembre – 19 de enero
            if (Month == 1)
            {
                if (day <= 20)
                {
                    ViewBag.resultado = "Capricornio";
                }
            }
            else if (Month == 2)
            {

            }
            else if (Month == 3)
            {

            }
            else if (Month == 4)
            {

            }
            else if (Month == 5)
            {

            }
            else if (Month == 6)
            {

            }
            else if (Month == 7)
            {

            }
            else if (Month == 8)
            {

            }
            else if (Month == 9)
            {

            }
            else if (Month == 10)
            {

            }
               

            //var resultado = "";
            //ViewBag.resultado = resultado;
            return View("CalculateZodiacSign");
        }
    }
}