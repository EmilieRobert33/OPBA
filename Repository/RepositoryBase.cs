using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;


namespace Repository
{
    /// <summary>
    /// A CSClass definition.
    /// </summary>
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        #region fields
        private RepositoryContext _repo;
        #endregion

        #region properties

        #endregion

        #region constructors

        public RepositoryBase(RepositoryContext repo)
        {
            _repo = repo;
        }

        #endregion

        #region methods
        public IQueryable<T> FindAll()
        {
            return _repo.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _repo.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
             _repo.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _repo.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _repo.Set<T>().Remove(entity);
        }
        #endregion
    }
}
