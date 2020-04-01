using BusTicketReservationSystem.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpringMvcApp.DataLayer.Mapping
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
        Id(x => x.CustomerId);

            Map(x => x.Name);
            Map(x => x.Address);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.Country);
            Map(x => x.PinCode);
            Map(x => x.Email);
            Map(x => x.Gender);
            Map(x => x.ContactNo);
            Map(x => x.DateOfBirth);
            Map(x => x.CustomerType);
            Map(x => x.Password);
            Map(x => x.ConfirmPassword);
            
            Table("Customer");
        }
    }
}
    
