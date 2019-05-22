using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REST.Api.Dtos;
using REST.Core.Interafaces;
using REST.Data.Models;

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
        public IActionResult GetAllUsers()
        {
            var userEntity = _userService.GetAllUsers();
            var results = Mapper.Map<IEnumerable<UserDto>>(userEntity);
            
            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            if (!_userService.UserExist(id))
            {
                return NotFound();
            }

            var userEntity = _userService.GetUserById(id);
            var result = Mapper.Map<UserDto>(userEntity);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserForCreationDto userForCreation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userToAdd = Mapper.Map<User>(userForCreation);
            _userService.Add(userToAdd);
            var userResult = Mapper.Map<UserDto>(userToAdd);
            
            return Ok(userResult);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody]UserForUpdateDto userForUpdate)
        {
            if (userForUpdate == null)
            {
                return BadRequest();
            }

            if (!_userService.UserExist(id))
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userEntity = _userService.GetUserById(id);
            Mapper.Map(userForUpdate, userEntity);

            _userService.Update(userEntity);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (!_userService.UserExist(id))
            {
                return NotFound();
            }

            var userToDelete = _userService.GetUserById(id);
            _userService.Delete(userToDelete);

            return NoContent();
        }

    }
}
