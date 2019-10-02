using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TraineeShop.Core.DataBase;
using TraineeShop.Core.Models;

namespace TraineeShop.Core.Repository
{
    public class CarRepository : IRepository<Car>
    {
        private ApplicationContext db;
        public CarRepository()
        {
            this.db = new ApplicationContext();
        }
        public void Create(Car item)
        {
            db.Cars.Add(item);
                db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Car car = Get(id);
            if (car != null)
                db.Cars.Remove(car);
            db.SaveChanges();
        }

        public Car Get(Guid id) => db.Cars.Include(x => x.Company).ToList<Car>().Find(x=>x.Id==id);


        public IEnumerable<Car> GetAll() => db.Cars.Include(x => x.Company);

        public void Update(Car item)
        {
            db.Update(item);
            db.SaveChanges();
        }
    }
}