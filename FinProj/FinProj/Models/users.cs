using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinProj.Models
{
    public class users
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //public string Phone { get; set; }
        //public string Country { get; set; }
        //public string Street { get; set; }
        //public string DefaultShipping { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
