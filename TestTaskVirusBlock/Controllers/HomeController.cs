using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestTaskVirusBlock.Models;
using TestTaskVirusBlock.ModelsPL;
using TestTaskVirusBlock.Services;

namespace TestTaskVirusBlock.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarService _carService = new CarService();
        private readonly PersonService _personService = new PersonService();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var carsList = _carService.GetAllCars();
            ViewBag.Cars = carsList;
            var personList = _personService.GetAllPersons();
            ViewBag.Persons = personList;
            return View();
        }

        [HttpGet]
        public ActionResult NewCar()
        {
            return View();
        }

        [HttpPost]
        public string NewCar(CarPL carPl)
        {
            string guid = _carService.CreateCar(carPl);
            return "Новое авто с ИД - " + guid + " успешно создано!";
        }

        [HttpGet]
        public ActionResult NewPerson()
        {
            return View();
        }

        [HttpPost]
        public string NewPerson(PersonPL personPL)
        {
            string guid = _personService.CreatePerson(personPL);
            return "Новый человек с ИД - " + guid + " успешно создан!";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
