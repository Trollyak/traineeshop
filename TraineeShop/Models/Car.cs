using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeShop.Models
{
    public class Car
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal? price { get; set; }
        //public Company company { get; set; }
       

    }
}