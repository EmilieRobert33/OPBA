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
    ///Interface for wrapping all repository needed.
    /// </summary>
    public interface IRepositoryWrapper
    {
        #region properties
        IUserRepository User { get; }
        //TODO à compléter avec la classe Session

        #endregion

        #region methods
        void Save();
        #endregion
    }
}
