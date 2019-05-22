using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using REST.Api.Dtos;
using REST.Data.Models;

namespace REST.Core.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserForCreationDto, User>();
            CreateMap<UserForUpdateDto, User>();
        }
    }
}
