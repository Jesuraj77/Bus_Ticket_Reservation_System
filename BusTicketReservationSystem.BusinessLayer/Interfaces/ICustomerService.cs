using BusTicketReservationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketReservationSystem.BusinessLayer.Interfaces
{
    public interface ICustomerService
    {
        bool SignUp(Customer customer);
        bool SignIn(string Name, string Password);
        bool SignOut(string customerId);
        bool ChangePassword(string Password);
        Customer GetCustomer(string customerId);
        bool BookTicket(Ticket ticket);
        bool UpdateTicket(Ticket ticket);
        bool CancelTicket(Ticket ticket);

    }
}
