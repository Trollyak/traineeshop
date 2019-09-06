using System;
using System.Collections.Generic;
using System.Linq;
using TraineeShop.Models;
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
            return View();
        }
        [HttpPost]
        public ActionResult AddCar(Car car)
        {
            return View();
        }


    }
}