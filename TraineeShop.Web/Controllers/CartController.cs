using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraineeShop.Core.Models;
using TraineeShop.Core.DataBase;
using TraineeShop.Core.Helpers;

namespace TraineeShop.Web.Controllers
{
    public class CartController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            //  ViewBag.total = cart.Sum(i => i.Car.Price * i.Quantity);
            return View();
        }

        public IActionResult Buy(Guid id)
        {
            if (SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart") == null)
            {
                var cart = new List<CartItem>();
                cart.Add(new CartItem()
                {
                    Car = db.Cars.Find(id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new CartItem()
                    {
                        Car = db.Cars.Find(id),
                        Quantity = 1
                    });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            }
            return RedirectToAction("Index");
        }
        private int Exists(List<CartItem> cart, Guid id)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Car.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}