using BusTicketReservationSystem.BusinessLayer.Interfaces;
using BusTicketReservationSystem.BusinessLayer.Services;
using BusTicketReservationSystem.Entities;
using NSubstitute;
using SpringMvcApp.DataLayer.NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace BusTicketReservationSystem.Tests.TestCases
{
    public class BounadryTests
    {
        private readonly ICustomerService _service;
        private readonly IAdministratorService _services;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public BounadryTests()
        {
            _service = new CustomerServices(_session);
        }


        [Fact]
        public void Boundary_Testfor_ValidEmail()
        {
            //Action
            var customer = new Customer()
            {
                CustomerId = "1234",
                Name = "Rose",
                Address = "Bangalore",
                City = "Bangalore",
                State = "Karnataka",
                Country = "India",
                PinCode = 600867,
                Email = "abc@gmail.com",
                Gender = "Female",
                DateOfBirth = new DateTime(1990, 04, 12),
                CustomerType = "Normal",
                Password = "123456789",
                ConfirmPassword = "123456789",
            };

            bool isEmail = Regex.IsMatch(customer.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
        }

        [Fact]
        public void Boundary_Testfor_ValidPincode()
        {
            //Action
            var customer = new Customer()
            {
                CustomerId = "1234",
                Name = "Rose",
                Address = "Bangalore",
                City = "Bangalore",
                State = "Karnataka",
                Country = "India",
                PinCode = 600867,
                Email = "abc@gmail.com",
                Gender = "Female",
                DateOfBirth = new DateTime(1990, 04, 12),
                CustomerType = "Normal",
                Password = "123456789",
                ConfirmPassword = "123456789",
            };

            //Assert
            Assert.Equal(6, customer.PinCode.ToString().Length);
        }

        [Fact]
        public void Boundary_Testfor_ValidContactNumber()
        {
            //Action
            var customer = new Customer()
            {
                CustomerId = "1234",
                Name = "Rose",
                Address = "Bangalore",
                City = "Bangalore",
                State = "Karnataka",
                Country = "India",
                PinCode = 600867,
                Email = "abc@gmail.com",
                Gender = "Female",
                ContactNo=9763542562,
                DateOfBirth = new DateTime(1990, 04, 12),
                CustomerType = "Normal",
                Password = "123456789",
                ConfirmPassword = "123456789",
            };

            //Assert
            Assert.Equal(10, customer.ContactNo.ToString().Length);
        }

        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
            var customer = new Customer()
            {
                CustomerId = "1234",
                Name = "Rose",
                Address = "Bangalore",
                City = "Bangalore",
                State = "Karnataka",
                Country = "India",
                PinCode = 600867,
                Email = "abc@gmail.com",
                Gender = "Female",
                DateOfBirth = new DateTime(1990, 04, 12),
                CustomerType = "Normal",
                Password = "123456789",
                ConfirmPassword = "123456789",
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = customer.Password.Length;

            //Assert
            Assert.Equal(customer.Password, customer.ConfirmPassword);
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserName_Length()
        {
            //Arrange
            var customer = new Customer()
            {
                CustomerId = "1234",
                Name = "Rose",
                Address = "Bangalore",
                City = "Bangalore",
                State = "Karnataka",
                Country = "India",
                PinCode = 600867,
                Email = "abc@gmail.com",
                Gender = "Female",
                DateOfBirth = new DateTime(1990, 04, 12),
                CustomerType = "Normal",
                Password = "123456789",
                ConfirmPassword = "123456789",
            };
            var MinLength = 2;
            var MaxLength = 50;

            //Action
            var actualLength = customer.Name.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
    }
      
}