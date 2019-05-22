using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Api.Dtos
{
    public class UserForCreationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FavoriteSport { get; set; }
    }
}
