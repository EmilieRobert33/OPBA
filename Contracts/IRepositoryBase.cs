using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;


namespace Contracts
{
    /// <summary>
    /// Interface for repository pattern operations
    /// </summary>
    public interface IRepositoryBase<T>
    {      

        #region properties

        #endregion

        #region methods
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        #endregion
    }
}
