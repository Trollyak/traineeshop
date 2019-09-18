using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraineeShop.Models;
using TraineeShop.Repository;

namespace TraineeShop.Web.Controllers
{
    public class CarsController : Controller
    {
        IRepository<Car> CarDb = new CarRepository();
        public IActionResult Index()
        {
            return View(CarDb.GetAll().ToList());
        }
        public ActionResult Product(Guid id)
        {
            return View(CarDb.Get(id));
        }
        
    }
}