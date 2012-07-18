using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SmartMart3.Models
{
    public class SaleEntities : DbContext
    {
        public DbSet<Account> dbAccount { get; set; }
    }
}