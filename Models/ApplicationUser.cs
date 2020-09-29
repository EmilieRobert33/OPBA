using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;


namespace Models
{
    /// <summary>
    /// A CSClass definition.
    /// </summary>
    public sealed class ApplicationUser 
    {
        #region fields

        #endregion

        #region properties
        public string UserId { get; set; }
        [Display(Name ="Prénom")]
        public string FirstName { get; set; }
        
        #endregion

        #region constructors

        public ApplicationUser()
        {
        }

        #endregion

        #region methods

        #endregion
    }
}
