using System;
using System.Collections.Generic;
using System.Text;

namespace FinProj.Models
{
    internal class ProductDb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public double ActualPrice { get; set; }
        public double DiscountPrice { get; set; }
        public bool IsFavourite { get; set; }


        public string PreviewImage
        {
            get;set;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
