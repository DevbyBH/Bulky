using Bulky.DataAccess.Repository.IRepository;
using BulkyWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }

        void IRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.Get(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Remove(T entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.RemoveRange(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
