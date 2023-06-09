using Microsoft.EntityFrameworkCore;
using MiniStore.Domain.Interfaces.Base;
using System.Linq.Expressions;
using MiniStore.Infra.Data.Context;

namespace MiniStore.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected MiniStoreDbContext _context;
        public Repository(MiniStoreDbContext contexto)
        {
            _context = contexto;
        }

        public IQueryable<T> Get()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public T GetById(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().AsNoTracking().SingleOrDefault(predicate);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<T>().Update(entity);
        }
    }
}
