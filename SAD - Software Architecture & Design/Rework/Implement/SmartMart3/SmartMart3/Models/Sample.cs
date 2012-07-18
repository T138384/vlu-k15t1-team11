using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Net;

namespace SmartMart3.Models
{
    public class Sample //: DropCreateDatabaseIfModelChanges<SaleEntities>
    {
        public List<Account> account;
        public void cheat()
        {
            account = new List<Account>
            {
                new Account {Id = 1,strUsername = "cash01", strPassword = "cash01"},
                new Account {Id = 3,strUsername = "cash02", strPassword = "cash02"},
                new Account {Id = 2,strUsername = "cash03", strPassword = "cash03"}
            };
        }








        //protected override void Seed(SaleEntities context)
        //{

        //    var account = new List<Account>
        //    {
        //        new Account {Id = 1,strUsername = "cash01", strPassword = "cash01"},
        //        new Account {Id = 3,strUsername = "cash02", strPassword = "cash02"},
        //        new Account {Id = 2,strUsername = "cash03", strPassword = "cash03"}
        //    };
        //}

    }
}