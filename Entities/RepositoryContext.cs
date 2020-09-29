using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;


namespace Entities
{
    /// <summary>
    /// Repository Context.
    /// </summary>
    public sealed class RepositoryContext : DbContext
    {
        #region fields

        #endregion

        #region properties
        public DbSet<UserApplication> Users { get; set; }
        #endregion

        #region constructors

        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }

        #endregion

        #region methods

        #endregion
    }
}
