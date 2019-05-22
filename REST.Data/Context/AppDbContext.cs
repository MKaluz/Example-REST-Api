using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using REST.Data.Models;

namespace REST.Data.Context
{
   public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
        :base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
