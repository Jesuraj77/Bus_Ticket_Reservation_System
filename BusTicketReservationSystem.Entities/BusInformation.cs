using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketReservationSystem.Entities
{
   public class BusInformation
    {
        public string BusId { get; set; }
        public string BusName { get; set; }
        public string BusType { get; set; }
        public int Capacity { get; set; }
    }
}
