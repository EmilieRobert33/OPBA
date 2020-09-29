using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;


namespace Entities.Models
{
    /// <summary>
    /// A Class that define UserApplication model.
    /// </summary>
    
    public sealed class UserApplication
    {
        #region fields

        #endregion

        #region properties
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Veuillez indiquer votre nom")]
        [StringLength(60, ErrorMessage ="Votre nom ne peut pas dépasser 60 charactères")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer votre prénom")]
        [StringLength(60, ErrorMessage = "Votre prénom ne peut pas dépasser 60 charactères")]
        public string LastName { get; set; }

        #endregion

        #region constructors

        public UserApplication()
        {
        }

        #endregion

        #region methods

        #endregion
    }
}
