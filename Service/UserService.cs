using Domain.Entity;
using Domain.Interfaces;
using Services;
using Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService:IUserServices
    {
        private readonly IUserRepository _repository;
            public UserService (IUserRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<User> GetUsers()
        {
            return _repository.GetUsers();
        }
    }
}
