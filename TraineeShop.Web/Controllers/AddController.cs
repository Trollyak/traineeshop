using System;
using System.Collections.Generic;
using System.Linq;
using TraineeShop.Core.Models;
using TraineeShop.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraineeShop.Core.Repository;

namespace TraineeShop.Web.Controllers
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
                //var s = (from t in CompanyDb.GetAll() where t.Name == car.Company.Name select t).ToList();
                //car.Company.Country = s[0].Country;
                CarDb.Create(car);
                return View(GetCarViewModel());
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