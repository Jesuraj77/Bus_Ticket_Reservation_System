using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketReservationSystem.Entities
{
 public   class Ticket
    {
        public string CustomerId  { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime JourneyDate { get; set; }
        public DateTime Time { get; set; }
        public int NumberOfTickets { get; set; }
        public string BusId { get; set; }
        public int TicketCharge { get; set; }
    }
}
