using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Data.Repository
{
    public class DataRepository<T> : IDataRepository<T> where T : class
    {
        //<T> is generic class
        //Crud operations were implemented in concrete class

        private readonly TodoItemsContext _context;

        public DataRepository(TodoItemsContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> SaveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
