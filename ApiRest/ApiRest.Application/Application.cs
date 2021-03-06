using System;
using System.Collections.Generic;
using ApiRest.Abstractions;
using ApiRest.Repository;

namespace ApiRest.Application
{
    // agrego interface ICrud con su libreria
    public interface IApplication<T> : ICrud<T>
    {

    }

    public class Application<T> : IApplication<T>
    {
        // mediante injeccion de dependencia vinculo ambas clases creando el ctor y lo utilizo
        IRepository<T> _repository;

        public Application(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public T Save(T entity)
        {
            return _repository.Save(entity);
        }
    }
}
