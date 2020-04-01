using BusTicketReservationSystem.BusinessLayer.Interfaces;
using BusTicketReservationSystem.Entities;
using SpringMvcApp.DataLayer.NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketReservationSystem.BusinessLayer.Services
{
  public class AdministratorServices : IAdministratorService
    {
        private readonly IMapperSession _session;

        public AdministratorServices(IMapperSession session)
        {
            _session = session;
        }

        public bool AddNewBus(BusInformation bus)
        {
            throw new NotImplementedException();
        }

        public bool AddNewBusTypes(BusTypes bus)
        {
            throw new NotImplementedException();
        }

        public bool AddNewRoute(RouteInformation route)
        {
            throw new NotImplementedException();
        }

        public bool BookTicket(Ticket ticket, Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool CancelTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public int RefundAmountForCancelTicket(Ticket ticket, Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool ScheduleBus(BusInformation bus, Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProfile(string Customerid)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
