using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketReservationSystem.Entities
{
  public class Customer
    {
        public virtual string CustomerId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string City{ get; set; }
        public virtual string State{ get; set; }
        public virtual string Country{ get; set; }
        public virtual int PinCode { get; set; }
        public virtual string Email { get; set; }
        public virtual string Gender { get; set; }
        public virtual long ContactNo { get; set; }
        public virtual DateTime DateOfBirth{ get; set; }
        public virtual string CustomerType{ get; set; }
        public virtual string Password{ get; set; }
        public virtual string ConfirmPassword{ get; set; }
    }
}
