using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketReservationSystem.Entities
{
  public  class SeatAvailability
    {
        public string ScheduleId { get; set; }
        public DateTime DateOfJourney { get; set; }
        public int AvailableSeats { get; set; }
    }
}
