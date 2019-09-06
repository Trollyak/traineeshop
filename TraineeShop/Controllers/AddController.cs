using System;
using System.Collections.Generic;
using System.Linq;
using TraineeShop.Models;
using TraineeShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TraineeShop.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCompany(Company company)
        {
            return View();
        }
        public ActionResult AddCar()
        {
            var CarView = GetCarViewModel();
            return View(CarView);
        }
        [HttpPost]
        public ActionResult AddCar(Car car)
        {
            return View();
        }
        private CarViewModel GetCarViewModel() => new CarViewModel
        {
            Car = new Car(),
            Companies = new List<Company>
            {
                new Company{Id = Guid.NewGuid(), Name = "Tesla", Country = "USA"},
                new Company{Id = Guid.NewGuid(), Name = "Lada", Country = "Russia"},
                new Company{Id = Guid.NewGuid(), Name = "Mercedes-Benz", Country = "Deutschland" }
            }
        };

    }
}