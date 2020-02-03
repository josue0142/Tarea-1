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

        /// <summary>
        /// Calcula el signo zodiacal de una persona en base a su día y mes de nacimiento
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CalculateZodiacSign(DateTime dateTime)
        {
            int day = dateTime.Day;
            var Month = dateTime.Month;
          
            if (Month == 1)
            {
                //Capricornio 22 de diciembre – 19 de enero
                if (day < 20)
                {
                    ViewBag.resultado = "Capricornio";
                }
                else
                {
                    ViewBag.resultado = "Acuario";
                }
            }           
            else if (Month == 2)
            {
                //Acuario	20 de enero – 18 de febrero
                if (day < 19)
                {
                    ViewBag.resultado = "Acuario";
                }
                else
                {
                    ViewBag.resultado = "Piscis";
                }
            }            
            else if (Month == 3)
            {
                //Piscis  19 de febrero – 20 de marzo
                if (day < 21)
                {
                    ViewBag.resultado = "Piscis";
                }
                else
                {
                    ViewBag.resultado = "Aries";
                }
            }
            else if (Month == 4)
            {
                //Aries   21 de marzo – 20 de abril
                if (day < 21)
                {
                    ViewBag.resultado = "Aries";
                }
                else
                {
                    ViewBag.resultado = "Tauro";
                }
            }
            else if (Month == 5)
            {
                //Tauro	21 de abril – 20 de mayo
                if (day < 21)
                {
                    ViewBag.resultado = "Tauro";
                }
                else
                {
                    ViewBag.resultado = "Géminis";
                }
            }
            else if (Month == 6)
            {
                //Géminis 21 de mayo – 24 de junio
                if (day < 25)
                {
                    ViewBag.resultado = "Géminis";
                }
                else
                {
                    ViewBag.resultado = "Cáncer";
                }
            }
            else if (Month == 7)
            {
                //Cáncer  25 de junio – 22 de julio
                if (day < 23)
                {
                    ViewBag.resultado = "Cáncer";
                }
                else
                {
                    ViewBag.resultado = "Leo";
                }
            }
            else if (Month == 8)
            {
                //Leo	23 de julio – 23 de agosto	
                if (day < 24)
                {
                    ViewBag.resultado = "Leo";
                }
                else
                {
                    ViewBag.resultado = "Virgo";
                }
            }
            else if (Month == 9)
            {
                //Virgo   24 de agosto – 23 de septiembre
                if (day < 23)
                {
                    ViewBag.resultado = "Virgo";
                }
                else
                {
                    ViewBag.resultado = "Libra";
                }
            }
            else if (Month == 10)
            {
                //Libra	24 de septiembre – 22 de octubre
                if (day < 23)
                {
                    ViewBag.resultado = "Libra";
                }
                else
                {
                    ViewBag.resultado = "Escorpio";
                }
            }
            else if (Month == 11)
            {
                //Escorpio	23 de octubre – 21 de noviembre
                if (day < 22)
                {
                    ViewBag.resultado = "Escorpio";
                }
                else
                {
                    ViewBag.resultado = "Sagitario";
                }
            }
            else if (Month == 12)
            {
                //Sagitario	22 de noviembre – 21 de diciembre
                if (day < 22)
                {
                    ViewBag.resultado = "Sagitario";
                }
                else
                {
                    ViewBag.resultado = "Capricornio";
                }
            }

            return View("CalculateZodiacSign");
        }
    }
}