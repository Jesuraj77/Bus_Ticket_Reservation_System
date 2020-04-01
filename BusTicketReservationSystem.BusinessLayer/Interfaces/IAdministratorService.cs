using BusTicketReservationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketReservationSystem.BusinessLayer.Interfaces
{
 public interface IAdministratorService
    {
        bool AddNewBus(BusInformation bus);
        bool AddNewRoute(RouteInformation route);
        bool ScheduleBus(BusInformation bus, Customer customer);
        bool AddNewBusTypes(BusTypes bus);
        int RefundAmountForCancelTicket(Ticket ticket, Customer customer);
        bool BookTicket(Ticket ticket, Customer customer);
        bool UpdateTicket(Ticket ticket);
        bool CancelTicket(Ticket ticket);
        bool UpdateProfile(string Customerid);
    }
}
