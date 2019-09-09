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
            if (ModelState.IsValid)
                return Content(company.Name);
            else
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
            if (ModelState.IsValid)
                return Content("<h1>KeK</h1>");
            else
                return View(GetCarViewModel(car));
        }
        private CarViewModel GetCarViewModel(Car car = null) => new CarViewModel
        {
            
            Car = car ?? new Car(),
            Companies = new List<Company>
            {
                new Company{Id = Guid.NewGuid(), Name = "Tesla", Country = "USA"},
                new Company{Id = Guid.NewGuid(), Name = "Lada", Country = "Russia"},
                new Company{Id = Guid.NewGuid(), Name = "Mercedes-Benz", Country = "Deutschland" }
            }
        };

    }
}