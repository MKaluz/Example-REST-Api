using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using REST.Api.Dtos;
using REST.Core.Interafaces;

namespace REST.Api.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var userEntity = _userService.GetAllUsers();
            var results = Mapper.Map<IEnumerable<UserDto>>(userEntity);
            
            return Ok(results);
        }
    }
}
