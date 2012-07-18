using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMart3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int strName { get; set; }
        public int nQuantity { get; set; }
        public Category categoryclass { get; set; }
    }
}