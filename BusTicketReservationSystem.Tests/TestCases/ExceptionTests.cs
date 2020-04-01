using BusTicketReservationSystem.BusinessLayer.Interfaces;
using BusTicketReservationSystem.BusinessLayer.Services;
using BusTicketReservationSystem.Entities;
using BusTicketReservationSystem.Tests.Exceptions;
using NSubstitute;
using SpringMvcApp.DataLayer.NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusTicketReservationSystem.Tests.TestCases
{
   public class ExceptionTests
    {
        private readonly ICustomerService _service;
        private readonly IAdministratorService _services;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTests()
        {
            _service = new CustomerServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_CustomerNotFound()
        {
            
            //Assert
            var ex = Assert.Throws<CustomerNotFoundException>(() => _service.SignIn("ABC","123456"));
            Assert.Equal("User is Not Found Please SignUp", ex.message);
        }

        [Fact]
        public void ExceptionTestFor_ValidUser_InvalidPassword()
        {
           
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsException>(() => _service.SignIn("abc", "987654321"));
            Assert.Equal("Please enter valid usename & password", ex.message);
        }
        [Fact]
        public void ExceptionTestFor_InvalidUser_validPassword()
        {
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsException>(() => _service.SignIn("abc", "987654321"));
            Assert.Equal("Please enter valid usename & password", ex.message);
        }

        [Fact]
        public void ExceptionTestFor_ValidRegistration()
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

            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsException>(() => _service.SignUp(customer));
            Assert.Equal("Already have an Account please login", ex.message);
        }

    }
}
