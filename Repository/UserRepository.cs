using Contracts;
using Entities;
using Entities.Models;
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
    public sealed class UserRepository: RepositoryBase<UserApplication>,IUserRepository
    {
        #region fields

        #endregion

        #region properties

        #endregion

        #region constructors

        public UserRepository(RepositoryContext repo)
            :base(repo)
        {
        }

        #endregion

        #region methods

        #endregion
    }
}
