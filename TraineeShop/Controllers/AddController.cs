using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TraineeShop.Controllers
{
    public class AddController : Controller
    {
        public IActionResult AddCompany()
        {
            return View();
        } 
    }
}