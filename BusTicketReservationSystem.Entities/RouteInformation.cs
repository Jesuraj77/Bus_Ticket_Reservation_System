using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketReservationSystem.Entities
{
  public  class RouteInformation
    {
        public string RouteId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Cost { get; set; }
    }
}
