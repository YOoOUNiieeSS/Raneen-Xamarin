using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinProj.Models
{
    internal class WishList
    {
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserID { get; set; }
    }
}
