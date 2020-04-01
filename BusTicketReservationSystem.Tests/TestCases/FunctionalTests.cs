using BusTicketReservationSystem.BusinessLayer.Interfaces;
using BusTicketReservationSystem.BusinessLayer.Services;
using BusTicketReservationSystem.Entities;
using NSubstitute;
using SpringMvcApp.DataLayer.NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusTicketReservationSystem.Tests.TestCases
{
  public  class FunctionalTests
    {
        private readonly ICustomerService _service;
        private readonly IAdministratorService _services;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTests()
        {
            _service = new CustomerServices(_session);
        }

        [Fact]
        public void Test_For_Valid_Registration()
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
            //Action
            var IsRegistered = _service.SignUp(customer);
            //Assert
            Assert.True(IsRegistered);
        }

        [Fact]
        public void Test_For_Valid_SignIn()
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
            //Action
            var IsLogged = _service.SignIn(customer.Name, customer.Password);
            //Assert
            Assert.True(IsLogged);
        }

        [Fact]
        public void Test_For_Valid_AddNewBus()
        {
            //Arrange
            BusInformation bus = new BusInformation()
            {
                BusId ="b1",
                BusName="SemiAC",
                BusType="AC",
                Capacity=30
            };
            //Action
            var IsAdded = _services.AddNewBus(bus);
            //Assert
            Assert.True(IsAdded);
        }

        [Fact]
        public void Test_For_Valid_AddNewBusTypes()
        {
            //Arrange
            BusTypes bus = new BusTypes() {
                BusType = "AC",
                MaxSeats = 30
            };
            //Action
            var IsAdded = _services.AddNewBusTypes(bus);
            //Assert
            Assert.True(IsAdded);
        }

        [Fact]
        public void Test_For_Valid_AddNewRoute()
        {
            //Arrange
            RouteInformation route = new RouteInformation() {
                RouteId="R1",
                From="Coimbatore",
                To="Bangalore",
                Cost=1200
            };
            //Action
            var IsAdded = _services.AddNewRoute(route);
            //Assert
            Assert.True(IsAdded);
        }

        [Fact]
        public void Test_For_Valid_ScheduleBus()
        {
            //Arrange
            BusInformation bus = new BusInformation()
            {
                BusId = "b1",
                BusName = "SemiAC",
                BusType = "AC",
                Capacity = 30
            };
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
            var IsAdded = _services.ScheduleBus(bus, customer);
            //Assert
            Assert.True(IsAdded);
        }

        [Fact]
        public void Test_For_Valid_BookTicket()
        {
            //Arrange
            Ticket ticket = new Ticket() {
                CustomerId="c1",
                FromLocation="Bangalore",
                ToLocation="Delhi",
                BusId="B1",
                TicketCharge=1600
            };
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
            var IsBooked = _services.BookTicket(ticket, customer);
            //Assert
            Assert.True(IsBooked);
        }

        [Fact]
        public void Test_For_Valid_CancelTicket()
        {
            //Arrange
            Ticket ticket = new Ticket()
            {
                CustomerId = "c1",
                FromLocation = "Bangalore",
                ToLocation = "Delhi",
                BusId = "B1",
                TicketCharge = 1600
            };
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
            var IsCancelled = _services.CancelTicket(ticket);
            //Assert
            Assert.True(IsCancelled);
        }

        [Fact]
        public void Test_For_Valid_UpdateTicket()
        {
            //Arrange
            Ticket ticket = new Ticket()
            {
                CustomerId = "c1",
                FromLocation = "Bangalore",
                ToLocation = "Delhi",
                BusId = "B1",
                TicketCharge = 1600
            };

            //Action
            var IsUpdated = _services.UpdateTicket(ticket);
            //Assert
            Assert.True(IsUpdated);
        }

        [Fact]
        public void Test_For_Valid_UpdateProfile()
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

            //Action
            var IsUpdated = _services.UpdateProfile(customer.CustomerId);
            //Assert
            Assert.True(IsUpdated);
        }

    }
}
