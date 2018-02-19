using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;

namespace les2voorbeeld2_2018_02_19.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = { "rode kool", "spruitjes", "wortel", "spinazie" };
    
        public ViewResult Index (string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeiemiddag";
            return View();
        }

        public ViewResult Groenten (string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!String.IsNullOrEmpty(zoekGroente))
            {
             ViewBag.Zoekresultaat = $"De gezochte groente is " +
                                     $"de {Array.IndexOf(groenten, zoekGroente)+1}e uit de lijst.";
            }
           
            return View();
        }
        public ViewResult Studenten()
        {
            List<Student> studenten = new List<Student>
            {
                new Student {Id=23, Naam="Jefke", AfstudeerGraad=Graad.Voldoening},
                new Student {Id=22, Naam="Marieke", AfstudeerGraad=Graad.Onderscheiding},
            };
            ViewBag.Studenten = studenten;
            return View();
        }
    }
}