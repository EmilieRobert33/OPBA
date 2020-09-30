using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_OPBA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApplicationController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;

        public UserApplicationController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        //GET: api/User
        [HttpGet]
        public IEnumerable<UserApplication> Get()
        {
            var users = _repoWrapper.User.FindAll();

            return users;
        }

        
    }
}
