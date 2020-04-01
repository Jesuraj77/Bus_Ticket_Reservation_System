using BusTicketReservationSystem.BusinessLayer.Interfaces;
using BusTicketReservationSystem.Entities;
using SpringMvcApp.DataLayer.NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketReservationSystem.BusinessLayer.Services
{
    public class CustomerServices : ICustomerService
    {
        private readonly IMapperSession _session;

        public CustomerServices(IMapperSession session)
        {
            _session = session;
        }

        public bool BookTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public bool CancelTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public bool ChangePassword(string Password)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(string customerId)
        {
            throw new NotImplementedException();
        }

        public bool SignIn(string Name, string Password)
        {
            throw new NotImplementedException();
        }

        public bool SignOut(string customerId)
        {
            throw new NotImplementedException();
        }

        public bool SignUp(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
