using System;
using System.Collections.Generic;
using System.Linq;
using TraineeShop.Models;
using TraineeShop.DataBase;

namespace TraineeShop.Repository
{
    public class CompanyRepository:IRepository<Company>
    {
        private ApplicationContext db;
        public CompanyRepository()
        {
            this.db = new ApplicationContext();
        }
        public void Create(Company item)
        {
            db.Companies.Add(item);
            db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Company company = Get(id);
            if (company != null)
                db.Companies.Remove(company);
            db.SaveChanges();
        }

        public Company Get(Guid id) => db.Companies.Find(id);


        public IEnumerable<Company> GetAll() => db.Companies;

        public void Update(Company item)
        {
            db.Update(item);
            db.SaveChanges();
        }
    }
}
