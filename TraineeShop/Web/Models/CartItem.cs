using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeShop.Models;

namespace TraineeShop.Web.Models
{
    public class CartItem
    {
        public Car Car { get; set; }
        public int? Quantity { get; set; }
    }
}
