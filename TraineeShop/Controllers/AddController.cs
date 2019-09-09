using System;
using System.Collections.Generic;
using System.Linq;
using TraineeShop.Models;
using TraineeShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraineeShop.Repository;

namespace TraineeShop.Controllers
{
    
    public class AddController : Controller
    {
        IRepository<Car> CarDb = new CarRepository();
        IRepository<Company> CompanyDb = new CompanyRepository();
        // GET: Add
        public ActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCompany(Company company)
        {
            if (ModelState.IsValid)
            {
                CompanyDb.Create(company);
                return View();
            }
            else
                return View(company);
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
            {
                CarDb.Create(car);
                return View(GetCarViewModel(car));
            }
            else
                return View(GetCarViewModel(car));
        }
        private CarViewModel GetCarViewModel(Car car = null) => new CarViewModel
        {
            
            Car = car ?? new Car(),
            Companies = new List<Company>(CompanyDb.GetAll())
        };

    }
}