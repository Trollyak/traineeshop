using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeShop.Core.Models;

namespace TraineeShop.Core.Models
{
    public class CartItem
    {
        public Car Car { get; set; }
        public int? Quantity { get; set; }
    }
}
