using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private RepositoryContext _repo;
        private IUserRepository _user;

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repo);
                }

                return _user;
            }
        }

        //TODO for Seesion class Repository

        public RepositoryWrapper(RepositoryContext repo)
        {
            _repo = repo;
        }

        public void Save()
        {
            _repo.SaveChanges();
        }
    }
}
