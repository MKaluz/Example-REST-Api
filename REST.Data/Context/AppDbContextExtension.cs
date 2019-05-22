using System;
using System.Collections.Generic;
using System.Text;
using REST.Data.Models;

namespace REST.Data.Context
{
    public static class AppDbContextExtension
    {
        public static void EnsureSeedDataForContext(this AppDbContext context)
        {
            context.RemoveRange(context.Users);
            context.SaveChanges();

            var users = new List<User>()
            {
                new User()
                {
                    Name = "Jan",
                    Surname = "Kowalski",
                    FavoriteSport = "Basketball"
                },

                new User()
                {
                    Name = "John",
                    Surname = "Smith",
                    FavoriteSport = "Football"
                },

                new User()
                {
                    Name = "Anna",
                    Surname = "Clark",
                    FavoriteSport = "Running"
                },

                new User()
                {
                    Name = "Adam",
                    Surname = "White",
                    FavoriteSport = "Triathlon"
                }

            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }

        
    }
}
