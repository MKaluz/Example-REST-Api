using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
    }
}
