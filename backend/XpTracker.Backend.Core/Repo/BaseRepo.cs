using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using XpTracker.Backend.Core.Model.Common;
using XpTracker.Backend.Core.Repo.Common;
using XpTracker.Backend.Core.Service.Log;

namespace XpTracker.Backend.Core.Repo
{
    internal interface IBaseRepo<T> where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Refresh(T entity);
        void Clear();
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        void SaveChanges();
    }
    // TODO Add log
    internal class BaseRepo<T> : IBaseRepo<T> where T : AuditableEntity<int>
    {
        protected readonly IXpTrackerLogger _logger;
        protected IXpTrackerDbContext _context;
        protected DbSet<T> _dbset;

        internal BaseRepo(IXpTrackerDbContext context, IXpTrackerLogger logger)
        {
            this._logger = logger;
            _context = context;
            _dbset = _context.Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {
            return _dbset.AsQueryable<T>();
        }

        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _dbset.Remove(entity);
            _context.SaveChanges();
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _dbset.Add(entity);
            _context.SaveChanges();
        }

        public void Clear()
        {

            _dbset.RemoveRange(_dbset);
            this._context.SaveChanges();
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _dbset.Where(predicate);
            return query;
        }

        public virtual void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public void Refresh(T entity)
        {
            this._context.Entry<T>(entity).Reload();
        }
    }
}
