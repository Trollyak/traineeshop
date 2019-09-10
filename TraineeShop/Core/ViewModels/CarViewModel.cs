using System;
using System.Collections.Generic;
using System.Linq;
using TraineeShop.Models;

namespace TraineeShop.ViewModels
{
    public class CarViewModel
    {
        public List<Company> Companies { get; set; } = new List<Company>();
        public Car Car { get; set; } = new Car();
    }
}
