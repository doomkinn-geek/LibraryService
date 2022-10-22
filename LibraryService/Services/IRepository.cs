using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryService.Services
{
    public interface IRepository<T, TId>
    {
        TId Add(T item);

        int Update(T item);

        int Delete(T item);

        IList<T> GetAll();

        T GetById(TId id);
    }
}