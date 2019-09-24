using System;
using System.Collections.Generic;


namespace TraineeShop.Core.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Guid id);
        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(Guid id); // удаление объекта по id
    }
}