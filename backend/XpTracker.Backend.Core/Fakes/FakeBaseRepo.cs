using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using XpTracker.Backend.Core.Model.Common;
using XpTracker.Backend.Core.Repo;

namespace XpTracker.Backend.Core.Fakes
{
    internal class FakeBaseRepo<T> : IBaseRepo<T> where T : AuditableEntity<int>
    {
        //this is public so that we can temper with the storage for unit tests purpose
        public static readonly List<T> _inMemoryStorage = new List<T>();
        private static readonly object memoryLock = new object();

        public virtual void Create(T entity)
        {
            lock (memoryLock)
            {
                if (entity.Id == default(int))
                {
                    if (_inMemoryStorage.Count != 0)
                    {
                        entity.Id = _inMemoryStorage.Max(t => t.Id) + 1;
                    }
                    else
                    {
                        entity.Id = 1;
                    }
                }
                entity.CreatedDate = DateTime.Now;
                _inMemoryStorage.Add(entity);
            }
        }

        public virtual void Delete(T entity)
        {
            lock (memoryLock)
            {
                _inMemoryStorage.RemoveAll(e => e.Id == entity.Id);
            }
        }

        public virtual IQueryable<T> GetAll()
        {
            lock (memoryLock)
            {
                return _inMemoryStorage.AsQueryable();
            }
        }

        public virtual void Refresh(T entity)
        {
            //donothing
        }
        public virtual void Update(T entity)
        {
            lock (memoryLock)
            {
                entity.UpdatedDate = DateTime.Now;
                var original = _inMemoryStorage.First(e => e.Id == entity.Id);
                _inMemoryStorage.Remove(original);
                _inMemoryStorage.Add(entity);
            }
        }
        public virtual void Clear()
        {
            lock (memoryLock)
            {
                _inMemoryStorage.Clear();
            }
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _inMemoryStorage.AsQueryable().Where(predicate);
        }

        public void SaveChanges()
        {
            //donothing
        }
    }
}
