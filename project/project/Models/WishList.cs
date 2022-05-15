using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    internal class WishList
    {
        [AutoIncrement,PrimaryKey]
        public int WishListId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public override string ToString()
        {
            return WishListId.ToString();
        }
    }
}
