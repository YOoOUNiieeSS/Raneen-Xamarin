using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    internal class city
    {
        [PrimaryKey, AutoIncrement]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }

        public override string ToString()
        {
            return $"{CityName}";
        }
    }
}
