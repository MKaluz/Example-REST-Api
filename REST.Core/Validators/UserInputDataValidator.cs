using System;
using System.Collections.Generic;
using System.Text;
using REST.Core.Interfaces;
using REST.Data.Models;

namespace REST.Core.Validators
{
    public class UserInputDataValidator : IUserValidator
    {
        private const int MaxCharactersForName = 50;
        private const int MaxCharactersForSurname = 50;
        private const int MaxCharactersForFavoritSport = 30;

        public bool IsValid(User user)
        {
            if (user == null)
            {
                throw  new ArgumentNullException();
            }

            if (user.Name.Length == 0 || user.Surname.Length == 0)
            {
                return false;
            }
            

            if (user.Name == user.Surname || user.Name == user.FavoriteSport || user.Surname == user.FavoriteSport)
            {
                return false;
            }

            if (user.Name.Length > MaxCharactersForName)
            {
                return false;
            }

            if (user.Surname.Length > MaxCharactersForSurname)
            {
                return false;
            }

            if (user.FavoriteSport.Length > MaxCharactersForFavoritSport)
            {
                return false;
            }

            return true;
        }

    }
}
