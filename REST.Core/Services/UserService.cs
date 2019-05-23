using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using REST.Api.Dtos;
using REST.Core.Interafaces;
using REST.Core.Interfaces;
using REST.Core.Validators;
using REST.Data.Models;
using REST.Data.Repository;

namespace REST.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        private readonly IUserValidator _validator;

        public UserService(IRepository<User> repository, IUserValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _repository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _repository.Get(id);
        }

        public void Add(User user)
        {
            _repository.Add(user);
        }

        public void Update(User user)
        {
            _repository.Update(user);
        }

        public void Delete(User user)
        {
            _repository.Delete(user);
        }

        public bool UserExist(int id)
        {
            return _repository.GetAll().Any(u => u.Id == id);
        }

        public bool UserDataIsVaild(User user)
        {
           return _validator.IsValid(user);   
        }
    }
}
