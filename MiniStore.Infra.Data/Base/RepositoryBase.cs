using MiniStore.Domain.Base;

namespace MiniStore.Infra.Data.Base
{
    public abstract class RepositoryBase<T> where T : EntityBase
    {
        private readonly List<T> _entities;

        protected RepositoryBase()
        {
            _entities = new List<T>();
        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _entities.Add(entity);
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _entities.Remove(entity);
        }

        public T GetById(Guid id)
        {
            return _entities.Find(e => e.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }
    }
}
