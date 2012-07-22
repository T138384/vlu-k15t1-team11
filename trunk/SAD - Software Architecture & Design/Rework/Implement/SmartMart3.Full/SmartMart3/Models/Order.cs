using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMart3.Models
{
    public class cProduct
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int cost { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }       
        public int TotalPrice { get; set; }
        public int Score { get; set; }
        public string customerName { get; set; }

        
    }
    
}