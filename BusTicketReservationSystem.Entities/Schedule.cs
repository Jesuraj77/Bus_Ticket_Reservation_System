using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketReservationSystem.Entities
{
  public  class Schedule
    {
        public string ScheduleId { get; set; }
        public string RouteId { get; set; }
        public string BusId { get; set; }
        public DateTime Time { get; set; }
    }
}
