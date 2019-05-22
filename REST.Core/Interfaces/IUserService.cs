using System;
using System.Collections.Generic;
using System.Text;
using REST.Api.Dtos;
using REST.Data.Models;

namespace REST.Core.Interafaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(User user);

    }
}
