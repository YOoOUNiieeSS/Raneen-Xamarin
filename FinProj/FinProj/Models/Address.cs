using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinProj.Models
{
    internal class Address
    {
        [PrimaryKey, AutoIncrement]
        public int AddressId { get; set; }
        public int UserId { get; set; }
        //public int StateId { get; set; }
        //public int CityId { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
