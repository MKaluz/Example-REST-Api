using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using REST.Core.Validators;
using REST.Data.Models;
using Xunit;

namespace REST.Tests
{
    public class UserInputDataValidatorShould
    {
        [Theory]
        [InlineData("Jan", "Kowalski", "Football")]
        [InlineData("Adam", "Nowak", "")]
        [InlineData("John", "Smith", "Football")]
        public void AcceptValidData(string name, string surname , string favoriteSport)
        {
            var user = new User()
            {
                Name = name,
                Surname = surname,
                FavoriteSport = favoriteSport
            };

            var sut = new UserInputDataValidator();

            Assert.True(sut.IsValid(user));
        }

        [Theory]
        [InlineData("Jan", "Jan", "Football")]
        [InlineData("Adam", "Nowak", "Adam")]
        [InlineData("Adam", "Nowak", "Nowak")]
        [InlineData("", "", "Football")]
        [InlineData("Adam", "", "Football")]
        [InlineData("Adam", "", "")]
        [InlineData("AdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdam", "Smith", "Sport")]
        [InlineData("Smith", "AdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdam","Sport")]
        [InlineData("Smith", "Adam", "SportAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdamAdam")]
        public void RejectInvalidData(string name, string surname, string favoriteSport)
        {
            var user = new User()
            {
                Name = name,
                Surname = surname,
                FavoriteSport = favoriteSport
            };
            
            var sut = new UserInputDataValidator();

            Assert.False(sut.IsValid(user));
        }

        
    }
}
