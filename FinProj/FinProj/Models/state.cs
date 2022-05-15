using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinProj.Models
{
    internal class state
    {
        [PrimaryKey, AutoIncrement]
        public int StateID { get; set; }
        public string StateName { get; set; }

        public override string ToString()
        {
            return $"{StateName}";
        }
    }
}
