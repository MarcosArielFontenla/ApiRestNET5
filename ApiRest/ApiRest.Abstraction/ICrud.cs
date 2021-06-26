using System;
using System.Collections.Generic;

namespace ApiRest.Abstractions
{
    public interface ICrud<T>
    {
        // va a definir una operacion para actualizar
        T Save(T entity);

        // interface de lista para que me devuelva todas las entidades
        IList<T> GetAll();

        // obtener objetos por id
        T GetById(int id);

        // delete
        void Delete(int id);
    }
}
