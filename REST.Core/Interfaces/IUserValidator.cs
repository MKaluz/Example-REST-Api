using System;
using System.Collections.Generic;
using System.Text;
using REST.Data.Models;

namespace REST.Core.Interfaces
{
    public interface IUserValidator
    {
        bool IsValid(User user);
    }
}
