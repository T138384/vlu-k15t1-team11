﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMart3.Models
{
    public class cProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public List<cProduct> cproduct { get; set; }
        public int TotalPrice { get; set; }
        public bool PayWay { get; set; }
        public int Score { get; set; }
        public int Cash { get; set; }
        public bool CheckOut { get; set; }
    }
}